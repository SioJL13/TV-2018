using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobingTypeA : MonoBehaviour {

    private Vector3 _startPosition;
    private Quaternion _startRotation;
    public int translationSpeed;
    public int rotationSpeed;

    void Start() {
        this._startPosition = this.transform.position;
        this._startRotation = this.transform.rotation;
        this.translationSpeed = 7;
        this.rotationSpeed = 5;
}

    // Update is called once per frame
    void Update() {
        this.transform.position = this._startPosition + new Vector3(0.0f, Mathf.Cos(Time.time * translationSpeed) * 0.01f, 0.0f);
        this.transform.rotation = Quaternion.Euler(Mathf.Sin(Time.time * rotationSpeed), Mathf.Cos(Time.time * rotationSpeed) * 3, Mathf.Cos(Time.time * rotationSpeed) * 3);
    }
}
