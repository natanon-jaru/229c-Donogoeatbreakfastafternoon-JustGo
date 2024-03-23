using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField]private Rigidbody playerRb;
    private float speed = 0 ;
    [SerializeField] private List<GameObject> destPos;
    int destIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 finalDest = destPos[destIndex].transform.position;
        float distance = Vector3.Distance(playerRb.transform.position,finalDest);

        if (distance <= 0.5)
        {
            speed = 0;
            destIndex++;
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                speed = 60;
                
            }
        }
        
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 nextpos = Vector3.MoveTowards(transform.position,destPos[destIndex].transform.position,speed*Time.deltaTime);
        transform.position = nextpos;
    }

    
}
