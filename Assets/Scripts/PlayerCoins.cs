using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCoins : MonoBehaviour
{

	public int coin; 
	public int bonus;
	public Text carrotCountText;   

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
		carrotCountText.text = "x" + coin;
	}

	

}
