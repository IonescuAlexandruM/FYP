using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowNextLevel : MonoBehaviour
{
    [SerializeField] private Transform cave;
    [SerializeField] private Transform dungeon;

    private int numberOfObjects;

    private void Start()
    {
        numberOfObjects = transform.childCount;

    }
    // Update is called once per frame
    void Update()
    {
        if (cave.gameObject.activeInHierarchy == false && dungeon.gameObject.activeInHierarchy == false)
        {
            for (int i = 0; i < numberOfObjects; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }
        }
    }


}
