using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {

    public GameObject firstTent;
    public float minDistanceFromTent1;
    private bool reachedTent1;

	// Use this for initialization
	void Start () {
        this.reachedTent1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(firstTent.transform.position, this.transform.position) <= minDistanceFromTent1 && !this.reachedTent1) {
            firstTent.SetActive(true);
            this.reachedTent1 = true;
        }
	}
}
