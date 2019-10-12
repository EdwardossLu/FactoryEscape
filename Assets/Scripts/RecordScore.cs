using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordScore : MonoBehaviour 
{
    private float _recDistance;
	private int _recCoins;

	public TextMeshProUGUI distanceUI;
	public TextMeshProUGUI currencyUI;

	// Use this for initialization
    private void Start () 
	{
        _recDistance = UIManager.distance;
		_recCoins = UIManager.collectedCurrency;

		distanceUI = GameObject.Find("Canvas/DisRecord").GetComponent<TextMeshProUGUI>();
        currencyUI = GameObject.Find("Canvas/CoinRecord").GetComponent<TextMeshProUGUI>();
    }
	
	// Update is called once per frame
    private void Update () 
	{
        distanceUI.text = ((int)_recDistance).ToString() + "m";
        currencyUI.text = _recCoins.ToString() + "c";
    }
}
