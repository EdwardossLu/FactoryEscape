using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour 
{
    public GameObject explosive;

    private void Update ()
    {
        if (Input.GetKeyDown(KeyCode.B))
            RubbishLauncher();
    }

    private void RubbishLauncher()
    {
        Instantiate(explosive, new Vector3 (Random.Range(-20, 20),0), Quaternion.identity);
    }
}
