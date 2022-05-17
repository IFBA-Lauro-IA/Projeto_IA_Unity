using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;
    private float Horizontal;
    private float Vertical;

    public float Vel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        
    }

    void LateUpdate()
    {
        //Movement
        rb.AddForce(Horizontal * Vel ,0,Vertical * Vel);
    }

}
