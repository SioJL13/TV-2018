using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralButtonsSound : MonoBehaviour {

    public AudioSource tentSound;
    public float volume;

    // Use this for initialization
    void Start () {
        this.tentSound = this.GetComponent<AudioSource>();
        this.tentSound.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void stopAudio() {
        this.tentSound.Stop();
    }
}
