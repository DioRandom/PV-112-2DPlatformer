using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

	private Animator animatorComponent;

	private void Awake()
	{
		animatorComponent = GetComponent<Animator>();
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			PlayerCoins playerCoins = other.GetComponent<PlayerCoins>();
			playerCoins.Chest();
			animatorComponent.SetBool("IsOpen", true);
			GetComponent<Collider2D>().isTrigger = false;
			Destroy(this);
		}
	}
}
