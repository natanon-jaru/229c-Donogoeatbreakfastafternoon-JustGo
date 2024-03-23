using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<Rigidbody>().AddTorque(0,10,0);
       if (Input.GetMouseButtonDown(0))
       {
           GetComponent<Rigidbody>().AddTorque(0,0,0);
           GetComponent<Rigidbody>().AddForce(0,0,100);
       }
    }
}
