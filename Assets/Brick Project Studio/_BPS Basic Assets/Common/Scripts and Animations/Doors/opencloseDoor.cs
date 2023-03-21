﻿using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SojaExiles

{
    public class opencloseDoor : MonoBehaviour
    {

        public Animator openandclose;
        public Transform Player;
        public bool open;
        public float distance = 3;

        private PlayerControls playerControls;
        private InputAction action;

        void Awake()
        {
            playerControls = new PlayerControls();
        }

        void Start()
        {
            open = false;
        }

        private void OnEnable()
        {
            action = playerControls.Player.Action;
            action.Enable();
            action.performed += Action;

        }

        void Action(InputAction.CallbackContext context)
        {
            //Debug.Log("E pressed");
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);
                Debug.Log("Distance: " + dist);
                if (dist < distance)
                {
                    if (open == false)
                    {
                        StartCoroutine(opening());
                    }
                    else
                    {
                        if (open == true)
                        {
                            StartCoroutine(closing());
                        }
                    }
                }
            }

        }

        IEnumerator opening()
        {
            print("you are opening the door");
            openandclose.Play("Opening");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the door");
            openandclose.Play("Closing");
            open = false;
            yield return new WaitForSeconds(.5f);
        }


    }
}