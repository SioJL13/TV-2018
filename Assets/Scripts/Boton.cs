using UnityEngine;

public class Boton : MonoBehaviour {

 // This method triggers the switch that turns off the lights
 // It is implemented with a Pointer Down event within the buttons
    public void Onoff()
    {
        Luz.Apagador();

    }

   
}
