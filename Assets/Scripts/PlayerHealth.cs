using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class PlayerHealth : MonoBehaviour
{
	public Text loseText;
	public GameObject[] hearts;
	public int hp = 4;
	[HideInInspector]
	public Vector3 respawnPosition;

	public void TakeDamage(int damage)
	{
		hp -= damage;
		UpdateHearts();

		if (hp <= 0)
		{
			StartCoroutine(HandleDeath());
		}
		else
		{
			transform.position = respawnPosition;
		}
	}

	public void SetRespawnPosition(Vector3 position)
	{
		respawnPosition = position;
	}

	void UpdateHearts()
	{
		for (int i = 0; i < hearts.Length; i++)
		{
			hearts[i].SetActive(i < hp);
		}
	}

	IEnumerator HandleDeath()
	{
		Time.timeScale = 0.1f;
		loseText.text = "YOU LOSE";
		yield return new WaitForSeconds(1);
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
	}
}
