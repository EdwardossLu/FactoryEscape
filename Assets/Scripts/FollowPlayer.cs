using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
    public Transform target;
	private Vector3 _cameraOffest;

	[NonSerialized] [Range(0.01f, 1.0f)]
	public float smoothFactor = 0.5f;
	public bool lookAtPlayer = false;

	private void Start() 
    {
		_cameraOffest = transform.position - target.position;
	}

	private void Update () 
    {
		//transform.rotation = new Vector3 (target.position.x, transform.position.y, target.position.z - 1.5f);
		Vector3 newPos = target.position + _cameraOffest;
		transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

		if(lookAtPlayer)
			transform.LookAt(target);
	}
}
