using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlatform : MonoBehaviour {

    public PlatformFollow platformFollow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platformFollow.hasPlayerEntered = true;
        }
    }
}
