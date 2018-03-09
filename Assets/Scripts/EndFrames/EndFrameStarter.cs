using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFrameStarter : MonoBehaviour {

    public GameObject[] frames;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void callFrames()
    {
        foreach (GameObject item in frames)
        {
            item.GetComponent<EndFrame>().setFrameTexture();
        }
    }
}
