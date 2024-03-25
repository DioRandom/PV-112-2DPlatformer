using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			other.GetComponent<PlayerHealth>().SetRespawnPosition(transform.position);
		}
	}
}
