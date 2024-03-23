using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] public Transform center;

    [SerializeField] public float torque;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(center.position,Vector3.up, 50*Time.deltaTime);
        GetComponent<Rigidbody>().AddTorque(0,0,torque);
        
    }
}
