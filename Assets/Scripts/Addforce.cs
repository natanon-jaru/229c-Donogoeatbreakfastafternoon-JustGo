using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addforce : MonoBehaviour
{
    [SerializeField] private float force, mass, acc;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SetAccel();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            CalculateForce();
        }
    }

    void CalculateForce()
    {
        //mass = 5;
        //mass = GetComponent<Rigidbody>().mass;
        force = mass * acc;
        GetComponent<Rigidbody>().AddForce(force,force,0);
        
    }

    public void SetAccel()
    {
        acc += 1f;
    }
    
    

}
