using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticManager : MonoBehaviour
{
    public GameObject cos1;
    public GameObject cos2;

    private static int _selection = 0;

	private void Update ()
    {
        CosmeticChanges();
        NumberManager();
        //Debug.Log(selection);
    }

    private void CosmeticChanges()
    {
        switch (_selection)
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

    private static void NumberManager()
    {
        if (_selection <= 1)
            _selection = 1;

        if (_selection >= 2)
            _selection = 2;
    }

    public void SelectUp()
    {
        ++_selection;
    }

    public void SelectDown()
    {
        --_selection;
    }
}