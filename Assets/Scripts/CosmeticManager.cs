using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticManager : MonoBehaviour
{

    public GameObject cos1;
    public GameObject cos2;

    private static int selection = 0;

	void Update ()
    {
        CosmeticChanges();
        NumberManager();
        //Debug.Log(selection);
    }

    void CosmeticChanges()
    {
        switch (selection)
        {
            case 1:
                cos1.SetActive(true);
                cos2.SetActive(false);
                break;
            case 2:
                cos1.SetActive(false);
                cos2.SetActive(true);
                break;
            default:
                cos1.SetActive(false);
                cos2.SetActive(false);
                break;
        }
    }

    void NumberManager()
    {
        if (selection <= 1)
            selection = 1;

        if (selection >= 2)
            selection = 2;
    }

    public void SelectUp()
    {
        ++selection;
    }

    public void SelectDown()
    {
        --selection;
    }
}