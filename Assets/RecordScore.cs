using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordScore : MonoBehaviour {

	private float recDistance;
	private int recCoins;

	public TextMeshProUGUI distanceUI;
	public TextMeshProUGUI currencyUI;

	// Use this for initialization
	void Start () 
	{

		recDistance = UIManager.distance;
		recCoins = UIManager.collectedCurrency;

		distanceUI = GameObject.Find("Canvas/DisRecord").GetComponent<TextMeshProUGUI>();
        currencyUI = GameObject.Find("Canvas/CoinRecord").GetComponent<TextMeshProUGUI>();

	}
	
	// Update is called once per frame
	void Update () 
	{

        distanceUI.text = ((int)recDistance).ToString() + "m";
        currencyUI.text = recCoins.ToString() + "c";

	}
}
