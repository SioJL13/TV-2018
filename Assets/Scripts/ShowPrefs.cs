using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrefs : MonoBehaviour {
    public Text showTextStats;
    private string[] levelNames = {
        "Bullying",
        "Perro",
        "Homeless",
        "Ahogamiento",
        "Camion",
        "Abuela",
        "Calle",
        "Ladron",
        "Silla de Ruedas"
    };
    private int[] selections;
	// Use this for initialization
	void Start () {
        selections = new int[9];
        for(int i = 0; i < 9; i++) {
            string level = "Level" + (i + 1).ToString();
            selections[i] = PlayerPrefs.GetInt(level);
        }
        string stats = getProgress();
        Debug.Log(stats);
        showTextStats.text = stats;
    }

    private string getProgress() {
        string outString = "";

        int missedCounter = 0;
        int aCounter = 0;
        int bCounter = 0;
        int skipCounter = 0;

        for (int i = 0; i < 9; i++) {
            if (selections[i] == -1) {
                outString += "Level '" + levelNames[i] + "' was missed\n";
                missedCounter++;
            }
            else {
                string option = "";
                if (selections[i] == 2) {
                    skipCounter++;
                    option = "Skip";
                }
                else if (selections[i] == 0) {
                    option = "A";
                    aCounter++;
                }
                else if (selections[i] == 1) {
                    option = "B";
                    bCounter++;
                }

                outString += "In level '" + levelNames[0] + "' option " + option + " was selected\n";
            }
        }
        outString += "\n";
        string missedS = ((missedCounter / 9.0) * 100).ToString("N2");
        string skippedS = ((skipCounter / 9.0) * 100).ToString("N2");
        string aS = ((aCounter / 9.0) * 100).ToString("N2");
        string bS = ((bCounter / 9.0) * 100).ToString("N2");

        outString += missedS + "% of the story was missed\n";
        outString += skippedS + "% of the story was skipped\n";
        outString += aS + "% of the stories were solved using option A\n";
        outString += bS + "% of the stories were solved using option B\n";

        return outString;
    }
}
