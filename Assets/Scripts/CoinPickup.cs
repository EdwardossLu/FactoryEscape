using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public UIManager uIManager;
    public PlayCoinAudio playCoinAudio;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //playCoinAudio.CoinCollected();
            uIManager.UpdateCurrency();
            Destroy(gameObject);
        }
    }

}
