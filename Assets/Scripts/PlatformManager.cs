using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour {

    public static float platSpeed = 30f;

    private void Start() 
    {
        platSpeed = 30f;
    }

    //public void AdjustSpeed()
    //{
    //    if (platSpeed <= 70f)
    //    {
    //        platSpeed += 3f;
    //    }
    //}
}
