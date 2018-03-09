using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralButtonsSound : MonoBehaviour {

    private AudioSource audioSource;

    void Start () {
        this.audioSource = this.GetComponent<AudioSource>();
        this.audioSource.Play();
    }
	
    public void stopAudio() {
        this.audioSource.Stop();
    }
}
