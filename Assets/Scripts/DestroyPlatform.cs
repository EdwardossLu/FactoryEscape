using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public PlayerController playerController;
    public PlatformManager platformManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
            //platformManager.AdjustSpeed();
        }
    }
}
