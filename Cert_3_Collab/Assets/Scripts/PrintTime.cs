using System;
using UnityEngine;

public class PrintTime : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log((int)Time.time);
    }
}
