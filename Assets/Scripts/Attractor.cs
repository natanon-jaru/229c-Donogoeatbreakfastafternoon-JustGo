using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Attractor : MonoBehaviour
{
   [SerializeField] private Rigidbody rb;
   private float g = 100f;
   public static List<Attractor> Attractors;
   
   [SerializeField] public Transform center;

   private void FixedUpdate()
   {
      foreach (var att in Attractors)
      {
         if (att != this)
         {
                Attract(att);
         }
      }
   }

   void Attract(Attractor other)
   {
      Rigidbody rb2 = other.rb;
      Vector3 diret = rb.position - rb2.position;

      float distance = diret.magnitude;

      float forceMag = g * (rb2.mass * rb2.mass) / Mathf.Pow(distance, 2);
      Vector3 finalF = forceMag * diret.normalized;
     
      float dis = Vector3.Distance(this.transform.position, center.position);
      if (dis<=5)
      {
         Debug.Log("stop");
      }
      else
      {
         rb2.AddForce(finalF);
      }
      

   }

   private void OnEnable()
   {
      if (Attractors == null)
      {
         Attractors = new List<Attractor>();
      }
      
      Attractors.Add(this);
   }
}
