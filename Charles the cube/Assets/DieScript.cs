using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{
   public GameObject player;
   public GameObject target;
   private Vector3 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
 
 
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        Die();
    }
    void Die()
    {
        player.transform.position = targetPos;
    }
}

