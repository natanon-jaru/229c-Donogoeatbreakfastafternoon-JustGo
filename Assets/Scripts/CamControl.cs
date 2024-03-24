using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    [SerializeField] private Camera cam;

    [Header("Move")]
    private float moveSpeed;
    private float xInput;
    private float zInput;

    public static CamControl instance;

    [SerializeField] private Transform corner1;
    [SerializeField] private Transform corner2;
    
    void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    void Start()
    {
        moveSpeed = 50;
    }

    private void Update()
    {
        MoveByKB();
    }

    private void MoveByKB()
    {
        xInput = 0;
        zInput = Input.GetAxis("Horizontal");

        Vector3 dir = (transform.forward * zInput) + (transform.right * xInput);

        transform.position += dir * moveSpeed * Time.deltaTime;
        transform.position = Clamp(corner1.position, corner2.position);
    }

    private Vector3 Clamp(Vector3 lowerLeft, Vector3 topRight)
    {
        Vector3 pos = new Vector3(Mathf.Clamp(transform.position.x, lowerLeft.x, topRight.x),
            transform.position.y,
            Mathf.Clamp(transform.position.z, lowerLeft.z, topRight.z));

        return pos;
    }

}
