using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCoinAudio : MonoBehaviour
{

    public CoinPickup coinPickup;
    public AudioClip audioClip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void CoinCollected()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
