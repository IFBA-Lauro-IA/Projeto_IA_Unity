using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public Material playerMaterial;
    public static bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter()
    {
        if(playerMaterial.color == Color.red)
        {

        triggered = true;

        }
         if(playerMaterial.color == Color.blue)
        {

        triggered = false;

        }
    }
    public void OnTriggerExit()
    {
        triggered = false;
    }
}
