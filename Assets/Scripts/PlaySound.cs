using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySound : MonoBehaviour
{
    public Transform player;
    private AudioSource sound;
    
    
    private void Start()
    {
       sound= gameObject.transform.GetChild(0).GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(player)
        {
            StartCoroutine(PlaySoundCoroutine());
            
        }
    }

    IEnumerator PlaySoundCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        sound.PlayDelayed(3f);
    }
}
