using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour
{
   
    [SerializeField] private Transform ShootDir;
    [SerializeField] private LayerMask _layerMk  ;

// Update is called once per frame
    void Update()
    {

        Debug.DrawRay(ShootDir.transform.position, ShootDir.forward * 2002f, Color.red);

        /*if (Physics.Raycast(ShootDir.transform.position, transform.TransformDirection(ShootDir.forward),
                out RaycastHit raycastHit, 20f, _layerMk))
        {
            Debug.DrawRay(ShootDir.transform.position, ShootDir.forward * 20f, Color.cyan);
            raycastHit.collider.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
            raycastHit.collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }*/
    }
}
