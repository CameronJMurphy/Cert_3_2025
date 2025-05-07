using System;
using UnityEngine;
using System.Collections.Generic;

public class CameraControl : MonoBehaviour
{
    public float dampTime = 0.2f;
    private Transform target;
    private Vector3 velocity;
    private Vector3 desiredPos;
    private string[] orks = { "greg", "billy", "gorguz", "fred" };
    
    public List<string> tasks;
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player").transform;
       tasks = new List<string>();
    }

    void Update()
    {
        Move();
        Debug.Log(orks.Length);
        for(int i = 0; i < orks.Length; i++)
        {
            Debug.Log(orks[i]);
            tasks.Add(orks[i]);
        }
    }

    private void Move()
    {
        desiredPos = target.position;
        transform.position = Vector3.SmoothDamp(transform.position,desiredPos,ref velocity,dampTime);
    }
}
