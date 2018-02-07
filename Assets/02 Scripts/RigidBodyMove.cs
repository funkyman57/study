using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMove : MonoBehaviour {

    Rigidbody rb;
    public float forceMag = 20; // force magnitude
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");
        var inputDir = new Vector3(dx, 0, dz).normalized;
   

        //rb.AddForce(new Vector3(dx, 0, dz) * forceMag);
        rb.velocity = new Vector3(inputDir.x, rb.velocity.y / forceMag, inputDir.z) * forceMag;

        Debug.LogFormat("Velocity: {0}", rb.velocity.magnitude);
        
    }
    
}
