using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public GameObject firstTent;
    public float minDistanceFromTent1;
    private bool reachedTent1;
    public GameObject endSpawner;

	void Start () {
        this.reachedTent1 = false;
	}
	
	void Update () {
		if(Vector3.Distance(firstTent.transform.position, this.transform.position) <= minDistanceFromTent1 && !this.reachedTent1) {
            firstTent.SetActive(true);
            this.reachedTent1 = true;
        }
	}

    public void goToEnd() {
        this.transform.position = endSpawner.transform.position;
    }
}
