using System;
using UnityEngine;
using System.Collections.Generic;

public class CameraControl : MonoBehaviour
{
    public float dampTime = 0.2f;
    private Transform target;
    private Vector3 velocity;
    private Vector3 desiredPos;
    public float rotationSpeed = 30;
    void Start()
    {
       target = GameObject.FindGameObjectWithTag("CameraTarget").transform;
    }

    void Update()
    {
        Move();
        float y_mouse_axis = Input.GetAxisRaw("Mouse Y");
        transform.Rotate(Vector3.right,-y_mouse_axis * rotationSpeed * Time.deltaTime );
    }

    private void Move()
    {
        desiredPos = target.position;
        transform.position = Vector3.SmoothDamp(transform.position,desiredPos,ref velocity,dampTime);
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(player.position);
    }
}
