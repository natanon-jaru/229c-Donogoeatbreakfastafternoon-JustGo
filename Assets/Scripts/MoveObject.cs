using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private Transform NextPos;
    [SerializeField]private Rigidbody playerRb,netposRb;
    private float speed ;
    [SerializeField] private List<GameObject> destPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direct = playerRb.position - NextPos.position;
        
        
        if (Input.GetMouseButtonDown(0))
        {
            speed = 60;
        }
        else
        {
            if (direct.Equals(0))
            {
                speed = 0;
            }
        }
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 direc = this.transform.position - NextPos.position;
        transform.position = Vector3.MoveTowards(transform.position,NextPos.position,speed*Time.deltaTime);
        
    }
}
