using UnityEngine;

public class Luz : MonoBehaviour {
    //We search for all the Light objects in the scene to control them
    // Also we have a counter to control which light turns off
    public  Light[] Luces;
    //= (Light []) GameObject.FindObjectsOfType(typeof(Light));
    
    
    /*public  void Apagador ()
    {
        Luces[contador].enabled = !Luces[contador].enabled;
        Luces[contador + 1].enabled = !Luces[contador + 1].enabled;
        Debug.Log(Luces[contador].name);
        contador--;
        
    }*/


}
