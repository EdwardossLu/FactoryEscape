using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour 
{
    private float _speed;

    private void Start()
    {
        _speed = -PlatformManager.platSpeed;
    }

    //Moves the platform backwards.
    private void Update () 
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
