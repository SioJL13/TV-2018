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
    public Button goCredits;

    void Start() {

        // On button click set prefs
        setButton.onClick.AddListener(setPref);

        // On button click get prefs into console
        getButton.onClick.AddListener(getPref);

        // Go next scene
        goCredits.onClick.AddListener(nextScene);
    }

    void setPref() {
        int levelSelected = levelSelect.value + 1;
        int optionSelected = optionSelect.value;
        string levelKey = "Level" + levelSelected.ToString();
        PlayerPrefs.SetInt(levelKey, optionSelected);
    }

    void getPref() {
        int levelSelected = levelSelectGet.value + 1;
        string levelKey = "Level" + levelSelected.ToString();
        string optionSelected = PlayerPrefs.GetInt(levelKey).ToString();
        Debug.Log("Level " + levelSelected.ToString() + ": " + optionSelected);
    }

    void nextScene() {
        SceneManager.LoadScene("InventoryShow", LoadSceneMode.Single);
    }
}