using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFollow : MonoBehaviour {

    GameObject myPlayer;
    [HideInInspector] public bool hasPlayerEntered = false;

	// Use this for initialization
	void Start () {
        myPlayer = GameObject.Find("Player");
        hasPlayerEntered = false;
    }
	
	// Update is called once per frame
	void Update () {
		if (!hasPlayerEntered)
        {
            transform.position = new Vector3(myPlayer.gameObject.transform.position.x, transform.position.y, transform.position.z);
        }
	}
}
