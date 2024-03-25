using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

	public int level;

	public int count_coin;

	private void OnTriggerEnter2D(Collider2D other)
	{

		
		PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();


		if (other.tag == "Player" && count_coin == playerCoins.coin)
		{
			SceneManager.LoadScene(level);

		}
		else
			Debug.Log("error");
	}

}

