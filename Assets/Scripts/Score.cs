using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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
    
    
    
}
