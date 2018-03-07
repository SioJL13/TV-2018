using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {

    private GameObject vecinity;
    public GameObject nextVecinity;
    public int optionInt;

	void Start () {
        this.vecinity = this.transform.parent.gameObject;
	}


    void OnTriggerEnter(Collider other) {
        GameObject player;

        if (other.gameObject.tag == "Player") player = other.gameObject;
        else return;

        EventManager playerEvents = player.GetComponent<EventManager>();
        playerEvents.moveToNextButtons(this.vecinity, this.nextVecinity, optionInt);
    }
}
