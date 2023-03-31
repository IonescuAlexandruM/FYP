using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float force;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-1*transform.up * force*Time.fixedDeltaTime);

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
    }
}
