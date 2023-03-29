using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SojaExiles

{
    public class opencloseWindowApt : MonoBehaviour
    {

        public Animator openandclosewindow;
        public bool open;
        public Transform Player;

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
            Debug.Log("E pressed");
            if (Player)
            {
                float dist = Vector3.Distance(Player.position, transform.position);

                if (dist < 2.5)
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
            else Debug.Log("There is no player assigned to the window");

        }

        IEnumerator opening()
        {
            print("you are opening the Window");
            openandclosewindow.Play("Openingwindow");
            open = true;
            yield return new WaitForSeconds(.5f);
        }

        IEnumerator closing()
        {
            print("you are closing the Window");
            openandclosewindow.Play("Closingwindow");
            open = false;
            yield return new WaitForSeconds(.5f);
        }


    }
}