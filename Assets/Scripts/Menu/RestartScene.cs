using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {

    public GameObject PauseMenu;  //Make reference of this gameobject. 


	// Use this for initialization
	void Start () {
   
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void restart()
    {
        SceneManager.LoadScene("MainMenu"); //Restarts the player to main level. 
        Time.timeScale = 1;  //Restarts the run time. 
    }

}
