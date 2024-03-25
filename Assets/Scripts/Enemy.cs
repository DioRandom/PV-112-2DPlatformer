using UnityEngine;

public class Enemy : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
			if (playerHealth)
			{
				playerHealth.TakeDamage(1);
			}
		}
	}
}



