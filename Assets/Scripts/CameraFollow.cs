using System.Diagnostics;
using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[Header("Target")]
	public Transform target; // Об'єкт, за яким слідкує камера.

	[Header("Camera position restrictions")]
	public float minY;
	public float maxY;
	public float minX;
	public float maxX;

	private Vector3 lastTargetPosition;

	private void Update()
	{
		if (target == null) return; // Виходимо, якщо ціль не встановлена.

		if (lastTargetPosition != target.position)
		{
			UpdateCameraPosition();
			lastTargetPosition = target.position;
		}
	}

	void UpdateCameraPosition()
	{
		transform.position = new Vector3(
			Mathf.Clamp(target.position.x, minX, maxX),
			Mathf.Clamp(target.position.y, minY, maxY),
			transform.position.z
		);
	}
}
