using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour {

    //public PlatformManager platformManager;

    private float speed;

    private void Start()
    {
        speed = -PlatformManager.platSpeed;
    }

    //Moves the platform backwards.
    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
