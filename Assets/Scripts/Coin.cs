using UnityEngine;

public class Coin : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();
			playerCoins.Coin();
			Destroy(gameObject);
		}
	}
}
