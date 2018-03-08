using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralButtonsSound : MonoBehaviour {

    public AudioSource tentSound;
    public float volume;

    void Start () {
        this.tentSound = this.GetComponent<AudioSource>();
        this.tentSound.Play();
    }
	
    public void stopAudio() {
        this.tentSound.Stop();
    }
}
