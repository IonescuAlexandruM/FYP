using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    [SerializeField] private Transform player;


    // Update is called once per frame
    void Update()
    {
        if (player) 
        {
            Vector3 dir = player.position - transform.position;
            dir.Normalize();

            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
    }
}
