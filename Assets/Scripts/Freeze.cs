using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze: MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
    }
}
