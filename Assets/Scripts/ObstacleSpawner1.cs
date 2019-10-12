using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner1 : MonoBehaviour 
{
    public GameObject[] defaultPlatforms;
    private static float _fixedPos;

    void Start()
    {
        OriginalPlatforms();
        _fixedPos = 0f;
    }

    public void OriginalPlatforms()
    {
        var a = Random.Range(0, defaultPlatforms.Length);
        var b = Random.Range(0, defaultPlatforms.Length);
        var c = Random.Range(0, defaultPlatforms.Length);
        var d = Random.Range(0, defaultPlatforms.Length);
        var e = Random.Range(0, defaultPlatforms.Length);
        var f = Random.Range(0, defaultPlatforms.Length);
        var g = Random.Range(0, defaultPlatforms.Length);
        var h = Random.Range(0, defaultPlatforms.Length);
        var i = Random.Range(0, defaultPlatforms.Length);

        GameObject p1 = Instantiate(defaultPlatforms[a], new Vector3(_fixedPos, _fixedPos, 1100f), Quaternion.identity) as GameObject;
        p1.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p2 = Instantiate(defaultPlatforms[b], new Vector3(_fixedPos, _fixedPos, 1200f), Quaternion.identity) as GameObject;
        p2.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p3 = Instantiate(defaultPlatforms[c], new Vector3(_fixedPos, _fixedPos, 1300f), Quaternion.identity) as GameObject;
        p3.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p4 = Instantiate(defaultPlatforms[d], new Vector3(_fixedPos, _fixedPos, 1400f), Quaternion.identity) as GameObject;
        p4.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p5 = Instantiate(defaultPlatforms[e], new Vector3(_fixedPos, _fixedPos, 1500f), Quaternion.identity) as GameObject;
        p5.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p6 = Instantiate(defaultPlatforms[f], new Vector3(_fixedPos, _fixedPos, 1600f), Quaternion.identity) as GameObject;
        p6.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p7 = Instantiate(defaultPlatforms[g], new Vector3(_fixedPos, _fixedPos, 1700f), Quaternion.identity) as GameObject;
        p7.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p8 = Instantiate(defaultPlatforms[h], new Vector3(_fixedPos, _fixedPos, 1800f), Quaternion.identity) as GameObject;
        p8.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;

        GameObject p9 = Instantiate(defaultPlatforms[i], new Vector3(_fixedPos, _fixedPos, 1900f), Quaternion.identity) as GameObject;
        p9.transform.parent = GameObject.Find("DefaultPlatform2(Clone)").transform;
    }
}
