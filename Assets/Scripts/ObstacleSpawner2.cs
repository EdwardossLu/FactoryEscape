﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner2 : MonoBehaviour {

    public GameObject[] defaultPlatforms;

    private static float _fixedPos;

    void Start()
    {
        OriginalPlatforms();
        _fixedPos = 0f;
    }

    //Spawns random obstacles for the player to aviod.
    public void OriginalPlatforms()
    {

        int a = Random.Range(0, defaultPlatforms.Length);
        int b = Random.Range(0, defaultPlatforms.Length);
        int c = Random.Range(0, defaultPlatforms.Length);
        int d = Random.Range(0, defaultPlatforms.Length);
        int e = Random.Range(0, defaultPlatforms.Length);
        int f = Random.Range(0, defaultPlatforms.Length);
        int g = Random.Range(0, defaultPlatforms.Length);
        int h = Random.Range(0, defaultPlatforms.Length);
        int i = Random.Range(0, defaultPlatforms.Length);

        GameObject p1 = Instantiate(defaultPlatforms[a], new Vector3(_fixedPos, _fixedPos, 100f), Quaternion.identity) as GameObject;
        p1.transform.parent = GameObject.Find("Plat").transform;

        GameObject p2 = Instantiate(defaultPlatforms[b], new Vector3(_fixedPos, _fixedPos, 200f), Quaternion.identity) as GameObject;
        p2.transform.parent = GameObject.Find("Plat").transform;

        GameObject p3 = Instantiate(defaultPlatforms[c], new Vector3(_fixedPos, _fixedPos, 300f), Quaternion.identity) as GameObject;
        p3.transform.parent = GameObject.Find("Plat").transform;

        GameObject p4 = Instantiate(defaultPlatforms[d], new Vector3(_fixedPos, _fixedPos, 400f), Quaternion.identity) as GameObject;
        p4.transform.parent = GameObject.Find("Plat").transform;

        GameObject p5 = Instantiate(defaultPlatforms[e], new Vector3(_fixedPos, _fixedPos, 500f), Quaternion.identity) as GameObject;
        p5.transform.parent = GameObject.Find("Plat").transform;

        GameObject p6 = Instantiate(defaultPlatforms[f], new Vector3(_fixedPos, _fixedPos, 600f), Quaternion.identity) as GameObject;
        p6.transform.parent = GameObject.Find("Plat").transform;

        GameObject p7 = Instantiate(defaultPlatforms[g], new Vector3(_fixedPos, _fixedPos, 700f), Quaternion.identity) as GameObject;
        p7.transform.parent = GameObject.Find("Plat").transform;

        GameObject p8 = Instantiate(defaultPlatforms[h], new Vector3(_fixedPos, _fixedPos, 800f), Quaternion.identity) as GameObject;
        p8.transform.parent = GameObject.Find("Plat").transform;

        GameObject p9 = Instantiate(defaultPlatforms[i], new Vector3(_fixedPos, _fixedPos, 900f), Quaternion.identity) as GameObject;
        p9.transform.parent = GameObject.Find("Plat").transform;

    }
}