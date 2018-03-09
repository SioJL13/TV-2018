using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsAction : MonoBehaviour {

    public GameObject firstView;

	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(true);
        firstView.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void enableSettings ()
    {
        this.gameObject.SetActive(true);
        firstView.SetActive(false);
    }

    void disableSettings ()
    {
        this.gameObject.SetActive(false);
        firstView.SetActive(true);
    }
}
