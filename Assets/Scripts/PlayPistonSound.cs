using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPistonSound : MonoBehaviour
{
    public AudioClip stomp;
    public AudioSource audioS;

    private void StompSound()
    {
        audioS.PlayOneShot(stomp);
    }
}