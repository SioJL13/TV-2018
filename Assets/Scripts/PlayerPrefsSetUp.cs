using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPrefsSetUp : MonoBehaviour {

    public Dropdown levelSelect;
    public Dropdown levelSelectGet;
    public Dropdown optionSelect;
    public Button setButton;
    public Button getButton;

    void Start() {
        // Set up level selections to unselected
        // Option A = 0, option B = 1, option Default = 2
        // -1 is unassigned
        PlayerPrefs.SetInt("Level1Selection", -1);
        PlayerPrefs.SetInt("Level2Selection", -1);
        PlayerPrefs.SetInt("Level3Selection", -1);
        PlayerPrefs.SetInt("Level4Selection", -1);
        PlayerPrefs.SetInt("Level5Selection", -1);
        PlayerPrefs.SetInt("Level6Selection", -1);
        PlayerPrefs.SetInt("Level7Selection", -1);
        PlayerPrefs.SetInt("Level8Selection", -1);
        PlayerPrefs.SetInt("Level9Selection", -1);

        // On button click set prefs
        setButton.onClick.AddListener(setPref);

        // On button click get prefs into console
        getButton.onClick.AddListener(getPref);
    }

    void setPref() {
        int levelSelected = levelSelect.value + 1;
        int optionSelected = optionSelect.value;
        string levelKey = "Level" + levelSelected.ToString() + "Selection";
        PlayerPrefs.SetInt(levelKey, optionSelected);
    }

    void getPref() {
        int levelSelected = levelSelectGet.value + 1;
        string levelKey = "Level" + levelSelected.ToString() + "Selection";
        string optionSelected = PlayerPrefs.GetInt(levelKey).ToString();
        Debug.Log("Level " + levelSelected.ToString() + ": " + optionSelected);
    }

}