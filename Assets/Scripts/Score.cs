using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class Score : MonoBehaviour
{
    //[SerializeField] private List<GameObject> orbs;

    //private float time = 10f;
    
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
        GameManager.score++;
        Debug.Log(GameManager.score);
        DestroyThis();
       
    }

    void DestroyThis()
    {
            Destroy(this.GameObject());
    }

    /*private void OnTriggerStay(Collider other)
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
    }*/
    
    
}
