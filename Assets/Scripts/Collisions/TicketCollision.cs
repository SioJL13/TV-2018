using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicketCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "Charola") {
            Application.LoadLevel ("VR_Scene2");
        }
	}
}
