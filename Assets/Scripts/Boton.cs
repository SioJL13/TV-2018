using UnityEngine;

public class Boton : MonoBehaviour {
    public Light[] Luces;

    // This method triggers the switch that turns off the lights
    // It is implemented with a Pointer Down event within the buttons
    public void Onoff()
    {
        if (!Luces[Luces.Length - 1].enabled) {
            for (int i = 0; i < Luces.Length; i++) {
                if (Luces[i].enabled) {
                    this.Luces[i].enabled = !this.Luces[i].enabled;
                    this.Luces[i + 1].enabled = !this.Luces[i + 1].enabled;
                    i = Luces.Length+1;
                }
            }
        }
        

    }


    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Click");
            Onoff();

        }
         
            }

}
