using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public GameObject firstTent;
    public float minDistanceFromTent1;
    private bool reachedTent1;
    public GameObject endSpawner;
    private Vector3 prevPosition;
    private bool isWalking;
    private bool isRunning;
    public AudioSource audioSourceMovement;
    public AudioClip walkingSound;
    public AudioClip runningSound;
    private float lastCheckedTime;

    void Start () {
        this.reachedTent1 = false;
        this.prevPosition = this.transform.position;
        this.lastCheckedTime = Time.time;
    }

    void Update () {
        // Starts chain activation of carps if the plyer is near the first tent;
		if(Vector3.Distance(firstTent.transform.position, this.transform.position) <= minDistanceFromTent1 && !this.reachedTent1) {
            firstTent.SetActive(true);
            this.reachedTent1 = true;
        }
        
        // Checks for change of position when has passed at least 0.1 seconds
        if(Time.time - this.lastCheckedTime > 0.1) {
            // Decides which sound to play depending of 'suppossed' speed
            // Else, stops all audio (A movement smaller than 0.1 isn't considered as walking
            if (Vector3.Distance(this.transform.position, this.prevPosition) > 0.1) {
                // If player starts running (Distance to previous location is larger)
                if (Vector3.Distance(this.transform.position, this.prevPosition) > 1.0 && !this.isRunning) {

                    this.isWalking = false;
                    this.isRunning = true;
                    this.audioSourceMovement.Stop();
                    this.audioSourceMovement.clip = this.runningSound;
                    this.audioSourceMovement.Play();
                }
                // If player is just walking;
                else if (!this.isWalking) {
                    this.isWalking = true;
                    this.isRunning = false;
                    this.audioSourceMovement.Stop();
                    this.audioSourceMovement.clip = this.walkingSound;
                    this.audioSourceMovement.Play();
                }
            }
            else {
                this.isWalking = false;
                this.isRunning = false;
                this.audioSourceMovement.Stop();
            }
            this.prevPosition = this.transform.position; // Update location
            this.lastCheckedTime = Time.time;
        }
    }

    // Function called by the EventManager when all the stories have ended
    // It teleports the player to the end zone and calls for the summary of actions display
    public void goToEnd() {
        endSpawner.GetComponent<EndFrameStarter>().callFrames();
        this.transform.position = endSpawner.transform.position;
    }
}
