﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFireSwitcher : MonoBehaviour {

    public GameObject[] spawnPlatforms;

    // Use this for initialization
    void Start () {
        SpawnPlatform();

    }
	
    void SpawnPlatform()
    {
        int i = Random.Range(0, spawnPlatforms.Length);

        GameObject go = Instantiate(spawnPlatforms[i], new Vector3(0, 0, 1000f), Quaternion.identity) as GameObject;
        go.transform.parent = GameObject.Find("LavaPit(Clone)").transform;
    }
}
