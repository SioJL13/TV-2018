using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Vertical") * Vector3.forward * Time.deltaTime * speed, Space.Self);
        transform.Rotate(0, Input.GetAxis("Horizontal") * 50 * Time.deltaTime, 0, Space.Self);
	}
}
