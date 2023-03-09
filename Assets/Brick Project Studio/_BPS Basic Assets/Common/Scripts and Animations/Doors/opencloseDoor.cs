using StarterAssets;
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
        public bool open;
        public Transform Player;

        private StarterAssetsInputs _input;

        private PlayerControls playerControls;
        private InputAction action;

        void Awake()
        {
            playerControls = new PlayerControls();
        }

        void Start()
        {
            open = false;
            //_input = GetComponent<StarterAssetsInputs>();
            //_input = Player.GetComponent<StarterAssetsInputs>();
        }


        private void OnEnable()
        {
            action = playerControls.Player.Action;
            action.Enable();
            action.performed += Action;

            
            //Action();
        }

        void Action(InputAction.CallbackContext context)
        {
            Debug.Log("E pressed");
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);

                if (dist < 2.5)
                {
                    if (open == false)
                    {
                        // if (_input.action)
                        {

                            StartCoroutine(opening());
                        }
                    }
                    else
                    {
                        if (open == true)
                        {
                            //if (_input.action)
                            {
                                StartCoroutine(closing());
                            }
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