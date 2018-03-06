using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static  class Luz {
    //We search for all the Light objects in the scene to control them
    // Also we have a counter to control which light turns off
    public static Light [] Luces = (Light []) GameObject.FindObjectsOfType(typeof(Light));
    public static int contador = 0;

    public static void Apagador ()
    {
        Luces[contador].enabled = !Luces[contador].enabled;
        contador++;
    }


}
