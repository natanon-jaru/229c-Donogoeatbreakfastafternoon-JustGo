using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMagnus : MonoBehaviour
{
    private Rigidbody body;

    [SerializeField] private Vector3 velo, angularV;
    [SerializeField] private float force, mass, acceleration;

    private bool isHolding;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        mass = GetComponent<Rigidbody>().mass;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isHolding = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Perform calculation using the held number when key is released
            CalculateForce();
            // Reset the number for next use
            acceleration = 0f;
            force = 0f;
            isHolding = false;
        }

        // Increment the number while the key is held down
        if (isHolding)
        {
            acceleration += 1f;
        }
    }
    
    void CalculateForce()
    {
      force = mass * acceleration;
      GetComponent<Rigidbody>().AddForce(0,force,force);
      isHolding = false;
    }
    
}
