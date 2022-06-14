using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    [SerializeField] private Material myMaterial;
     public GameObject sensor;
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    public bool achou;

    public int rotVel = 2;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<NavMeshAgent>(); 
       UpdateDestination();

    }

    // Update is called once per frame
    void Update()
    {
       achou = Sensor.triggered;

        MachineState();
      //  transform.Rotation(0, rotVel* Time.deltaTime,0);
        if(Vector3.Distance(transform.position,target) < 1)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
        


        //Sensor
      
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }



    void MachineState()
    {
        // estado de "perseguição"
        if(achou)
        {
            Debug.Log("pegou!!!!");
            myMaterial.color = Color.red;
        }
        // Estado de Busca 
        if(!achou)
        {
            Debug.Log("Procurando...");
            myMaterial.color = Color.black;
        }
    }
}
