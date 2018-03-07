using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour {

    private bool[] status = { true, false, false, false, false, false, false, false, false };
    private int currentLevel = 0;
    public int numberOfCarps;

    // Movement shouldn't be here
    // Just for this branch testing
    private float movSpeed;

    void Start () {
		this.movSpeed = 5;

        // Set up level selections to unselected
        // Option A = 0, option B = 1, option Default = 2
        // -1 is unassigned
        PlayerPrefs.SetInt("Level1", -1);
        PlayerPrefs.SetInt("Level2", -1);
        PlayerPrefs.SetInt("Level3", -1);
        PlayerPrefs.SetInt("Level4", -1);
        PlayerPrefs.SetInt("Level5", -1);
        PlayerPrefs.SetInt("Level6", -1);
        PlayerPrefs.SetInt("Level7", -1);
        PlayerPrefs.SetInt("Level8", -1);
        PlayerPrefs.SetInt("Level9", -1);
    }
	
	// Update is called once per frame
	void Update () {
        // Movement shouldn't be here
        // Just for this branch testing
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (v != 0 || h != 0) {
            this.transform.Translate(movSpeed * h * Time.deltaTime, 0, movSpeed * v * Time.deltaTime, Space.World);
        }
    }    

    public void moveToNextButtons(GameObject vecinity, GameObject nextVecinity, int selectedOption) {
        int levelSelected = currentLevel + 1;
        int optionSelected = selectedOption;
        string levelKey = "Level" + levelSelected.ToString();
        PlayerPrefs.SetInt(levelKey, optionSelected);

        if (status[currentLevel] && !status[numberOfCarps-1]) {
            vecinity.SetActive(false);
            nextVecinity.SetActive(true);
            status[currentLevel] = false;
            status[++currentLevel] = true;
        }
        else if(status[numberOfCarps-1]) {
            vecinity.SetActive(false);
            StartCoroutine(nextLevel());
        }
    }

    IEnumerator nextLevel() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("InventoryShow", LoadSceneMode.Single);
    }
}
