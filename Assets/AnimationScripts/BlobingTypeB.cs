using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobingTypeB : MonoBehaviour {
    private Vector3 _startPosition;
    private Quaternion _startRotation;
    public int translationSpeed;
    public int rotationSpeed;

    void Start() {
        this._startPosition = this.transform.position;
        this._startRotation = this.transform.rotation;
        this.translationSpeed = 10;
        this.rotationSpeed = 5;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = this._startPosition + new Vector3(0.0f, Mathf.Sin(Time.time * translationSpeed) * 0.01f, 0.0f);
        this.transform.rotation = Quaternion.Euler(Mathf.Cos(Time.time * rotationSpeed), Mathf.Sin(Time.time * rotationSpeed) * 3, Mathf.Sin(Time.time * rotationSpeed) * 2);
    }
}
