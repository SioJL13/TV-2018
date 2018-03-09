using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFrame : MonoBehaviour {

    public Texture[] materials;
    public int level;
    private Renderer frameRenderer;

	// Use this for initialization
	void Start () {
        this.frameRenderer = this.GetComponent<Renderer>(); 
	}

    public void setFrameTexture()
    {
        int selectedOption = PlayerPrefs.GetInt("Level" + this.level);
        if (selectedOption != -1)
        {
            this.frameRenderer.material.mainTexture = this.materials[selectedOption];
        }
    }
}
