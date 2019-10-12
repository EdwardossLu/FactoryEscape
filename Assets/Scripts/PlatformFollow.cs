using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFollow : MonoBehaviour {

    GameObject _myPlayer;
    [HideInInspector] public bool hasPlayerEntered = false;

	// Use this for initialization
    private void Start () {
        _myPlayer = GameObject.Find("Player");
        hasPlayerEntered = false;
    }
	
	// Update is called once per frame
    private void Update () {
		if (!hasPlayerEntered)
        {
            Vector3 position = transform.position;
            position = new Vector3(_myPlayer.gameObject.transform.position.x, position.y, position.z);
            transform.position = position;
        }
	}
}
