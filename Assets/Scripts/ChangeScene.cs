using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Transform Player;
    public string scene;
    private void OnTriggerEnter(Collider other)
    {
        if (Player)
            SceneManager.LoadScene(scene);
    }
}
