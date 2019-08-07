﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour 
{
    public AudioClip audioClip;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void TriggerSound()
	{
		audioSource.PlayOneShot(audioClip);
	}
}