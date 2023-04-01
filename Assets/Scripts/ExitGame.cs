using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame: MonoBehaviour
{
    public Transform player;
    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
}
