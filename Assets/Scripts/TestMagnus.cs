using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMagnus : MonoBehaviour
{
    private Rigidbody body;

    [SerializeField] private Vector3 velo, angularV;
    [SerializeField] private float force, mass, acceleration;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        mass = GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            acceleration = 250; 
            force = mass * acceleration;
            GetComponent<Rigidbody>().AddForce(force,force,0);
        }
        
    }

    void Shoot()
    {
        
    }
    
    void CalculateForce()
    {
      
        
    }
}
