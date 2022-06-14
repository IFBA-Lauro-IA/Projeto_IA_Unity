using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody rb;
    private float Horizontal;
    private float Vertical;

    public float Vel;

    public Camera cam;
    private Vector3 camPos;
    public float offset;
    public float offsetX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camPos = new Vector3 (16,6,2 + offset);
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
        //Camera Config
    

       cam.transform.position = new Vector3 (16 + offsetX ,6 , offset + transform.position.z);
    }

    


}
