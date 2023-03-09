using Cinemachine;
using SojaExiles;
using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class OptionsMenu : MonoBehaviour
{

    private PlayerControls playerControls;
    private InputAction options;


    [SerializeField] private GameObject optionsUI;
    [SerializeField] private bool isPaused;




    void Awake()
    {
        playerControls = new PlayerControls();
    }



    private void OnEnable()
    {
        options = playerControls.Player.Pause;
        options.Enable();

        options.performed += Pause;
    }

    private void OnDisable()
    {
        options.Disable();
    }

    void Pause(InputAction.CallbackContext context)
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        optionsUI.SetActive(true);
        isPaused = true;


        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        optionsUI.SetActive(false);
        isPaused = false;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


}
