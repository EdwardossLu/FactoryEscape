using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour 
{
    private float _timeToDestory = 5f;

    private void Update()
    {
        _timeToDestory -= Time.deltaTime;
        if (_timeToDestory <= 0)
        {
            Destroy(gameObject);
        }
    }
}
