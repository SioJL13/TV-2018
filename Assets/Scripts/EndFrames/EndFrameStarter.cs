using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFrameStarter : MonoBehaviour {

    public GameObject[] frames;
    public AudioClip sadEnd;
    public AudioClip regularEnd;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void callFrames()
    {
        bool anySkip = false;
        for(int i = 1; i <= 9; i++)
        {
            if(PlayerPrefs.GetInt("level" + i) == -1)
            {
                anySkip = true;
                break;
            }
        }
        if(anySkip)
        {
            this.audioSource.clip = this.sadEnd;
        }
        else
        {
            this.audioSource.clip = this.regularEnd;
        }
        this.audioSource.Play();

        foreach (GameObject item in frames)
        {
            item.GetComponent<EndFrame>().setFrameTexture();
        }
    }
}
