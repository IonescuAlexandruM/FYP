using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public Transform player;
    private void OnTriggerEnter(Collider other)
    {
        if (player)
            gameObject.SetActive(false);
    }
}
