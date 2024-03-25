using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{

	public int coin; 
	public int bonus;
	public Text coinText;   

	private void Start()
	{
		UpdateCarrotUI();  
	}

	public void Coin()
	{
		coin++;
		UpdateCarrotUI();
	}

	public void Chest()
	{
		coin = coin + bonus;
		UpdateCarrotUI();
	}

	void UpdateCarrotUI()
	{
		coinText.text = "x" + coin;
	}

	

}
