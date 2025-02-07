using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moveplayer : MonoBehaviour
{
    private Rigidbody body;
    [SerializeField] private float force, mass, acceleration;

    private bool isHolding;

    [SerializeField] private Scene winS;
    
    private void Awake()
    {
        GameManager.score = 0;
    }
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
            CalculateForce();
            // Reset the num
            acceleration = 0f;
            force = 0f;
            isHolding = false;
        }

        // Increment the num
        if (isHolding)
        {
            acceleration += 2f;
        }
        
    }
    
    void CalculateForce()
    {
        force = mass * acceleration;
        GetComponent<Rigidbody>().AddForce(0,force,force);
        isHolding = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("DeathFloor"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FinishLine"))
        {
            //Debug.Log("des");
            SceneManager.LoadScene("Win");
        }
    }
}
