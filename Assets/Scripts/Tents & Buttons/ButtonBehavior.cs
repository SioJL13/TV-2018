using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {

    private GameObject vecinity;
    public GameObject nextVecinity;
    public GameObject EventManagerObj;
    public int optionInt;
    private bool touched;

	void Start () {
        this.vecinity = this.transform.parent.gameObject;
        this.touched = false;
	}

    bool isController(string name) {
        return name == "[VRTK][AUTOGEN][Controller][CollidersContainer]" || name == "SideA" || name == "SideB" || name == "Body" || name == "Head";
    }

    void OnTriggerEnter(Collider other) {
        if (isController(other.gameObject.name)) {
            StartCoroutine(holdItem());
        }        
    }

    void OnTriggerStay(Collider other) {
        if (isController(other.gameObject.name)) {
            if(touched) {
                EventManager playerEvents = EventManagerObj.GetComponent<EventManager>();
                playerEvents.moveToNextButtons(this.vecinity, this.nextVecinity, optionInt);
            }
        }
    }

    void OnTriggerExit(Collider other) {
        if (isController(other.gameObject.name)) {
            this.touched = false;
            StopCoroutine(holdItem());
        }
    }

    IEnumerator holdItem() {
        yield return new WaitForSeconds(1f);
        this.touched = true;
        yield break;
    }
}

