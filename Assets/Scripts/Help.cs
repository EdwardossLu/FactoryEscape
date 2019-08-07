using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Help : MonoBehaviour {

    private float timeToDestory = 5f;

    void Update()
    {
        timeToDestory -= Time.deltaTime;
        if (timeToDestory <= 0)
        {
            Destroy(gameObject);
        }
    }
}
