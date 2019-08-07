using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour {

    public GameObject[] platform;
    private int i;

    void Start()
    {
        i = Random.Range(0, platform.Length);
    }
    
    // Spawn a new platform ahead of the player.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(platform[i], transform.position = new Vector3(0, 0, 1499.5f), Quaternion.identity);
        }
    }
        
}
