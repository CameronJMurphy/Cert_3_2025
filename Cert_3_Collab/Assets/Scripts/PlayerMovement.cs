using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float force = 5.0f;
    public Vector3 dir = Vector3.right;
    CharacterController controller;
    public float speed = 100;
    public float rotationSpeed = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //rb.AddForce(dir * force);
        Vector3 dir = Vector3.zero;
        float h_axis = Input.GetAxisRaw("Horizontal");
        float v_axis = Input.GetAxisRaw("Vertical");
        dir = (v_axis * transform.forward  + h_axis * transform.right).normalized * Time.deltaTime * speed;
        Debug.Log(dir);
        controller.Move(dir);

        float x_mouse_axis = Input.GetAxisRaw("Mouse X");
        transform.Rotate(Vector3.up, x_mouse_axis * Time.deltaTime * rotationSpeed);
    }
}
