using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    Rigidbody rb;
    private float speed = 10000f;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * speed);
	}

}
