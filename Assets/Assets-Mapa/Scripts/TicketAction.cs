using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketAction : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Charola") {
				Application.LoadLevel ("VR_Scene2");
		}
  }
}
