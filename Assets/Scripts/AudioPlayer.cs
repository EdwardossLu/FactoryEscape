using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour 
{
    public AudioClip audioClip;
    public AudioSource audioSource;

	private void Start () 
	{
		audioSource = GetComponent<AudioSource>();
	}

    public void TriggerSound()
	{
		audioSource.PlayOneShot(audioClip);
	}
}
