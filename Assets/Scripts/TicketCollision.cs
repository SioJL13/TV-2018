using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TicketCollision : MonoBehaviour {

	public GameObject player;
	public GameObject spawner;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col) {
		print(col.gameObject.name);

    if (col.gameObject.name == "Buzon")
        {

			player.transform.position = spawner.transform.position;//(where you want to teleport
        //SceneManager.LoadScene("InGame");
        }
	}
}

//-170 5 25 Spawner
