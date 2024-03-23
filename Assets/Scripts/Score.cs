using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class Score : MonoBehaviour
{
    public static int score=0;
    [SerializeField] private List<GameObject> orbs;

    private float time = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        score++;
        Debug.Log(score);
       
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("here");
        float f = new Random().Next(20, 50);
        foreach (var all in orbs)
        {
            all.GetComponent<Rigidbody>().AddForce(0, f, 0);
            
            if (time ==0)
            {
                Destroy(all);
            }
            else
            {
                time-=0.5f;
            }
            
        }
    }
    
    
}
