using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI currencyUI;
    public TextMeshProUGUI distanceUI;
    public static int collectedCurrency;
    public static float distance;
    public QuestManager questManager;

	void Start()
    {
        
        distance = 0;
        collectedCurrency = 0;

        distanceUI = GameObject.Find("Canvas/Distance").GetComponent<TextMeshProUGUI>();
        currencyUI = GameObject.Find("Canvas/Currency").GetComponent<TextMeshProUGUI>();
    }
	
	void Update()
    {
        distanceUI.text = "Distances: "+ ((int)distance).ToString() + "m";
        currencyUI.text = "Coins: " + collectedCurrency.ToString();
    }

    void FixedUpdate()
    {
        distance += (5f * Time.deltaTime);
    }
    
    public void UpdateCurrency()
    {
        ++collectedCurrency;
    } 
}
