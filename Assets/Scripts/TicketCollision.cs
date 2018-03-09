using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TicketCollision : MonoBehaviour {

	public GameObject player;
	public GameObject spawner;
    public AudioSource audioSourceIntro;
    private bool playingIntro;

	// Use this for initialization
	void Start () {
        this.playingIntro = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Buzon") {
			player.transform.position = spawner.transform.position; // (where you want to teleport)
            if(!this.playingIntro) {
                this.audioSourceIntro.Play();
                this.playingIntro = true;
            }
        }
	}
}

//-170 5 25 Spawner
