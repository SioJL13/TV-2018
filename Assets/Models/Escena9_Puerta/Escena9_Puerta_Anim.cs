using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escena9_Puerta_Anim : MonoBehaviour {
    private Vector3 _startPosition;
    private Quaternion _startRotation;

    void Start () {
        this._startPosition = this.transform.position;
        this._startRotation = this.transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = this._startPosition + new Vector3(0.0f, Mathf.Sin(Time.time * 10) * 0.01f, 0.0f);
        this.transform.rotation = Quaternion.Euler(Mathf.Cos(Time.time * 5), Mathf.Sin(Time.time * 5) * 3, Mathf.Sin(Time.time * 5) * 2);
    }
}
