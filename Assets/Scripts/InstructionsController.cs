using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionsController : MonoBehaviour
{
    public Transform player;
    [SerializeField] private Image instructions;

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            gameObject.SetActive(false);
            instructions.gameObject.SetActive(false);
        }
    }
}
