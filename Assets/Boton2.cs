using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Boton2  {

    public static Light[] Luces = (Light[])GameObject.FindObjectsOfType(typeof(Light));
    public static int contador = 0;

    public static void Apagador() {
        Luces[contador].enabled = !Luces[contador].enabled;
        contador++;
    }
}
