using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private Rigidbody _rb;
    private const float Speed = 10000f;

    // Use this for initialization
	private void Start ()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(transform.forward * Speed);
	}

}
