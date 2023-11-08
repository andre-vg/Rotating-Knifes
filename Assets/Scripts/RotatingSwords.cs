using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingSwords : MonoBehaviour
{
	public GameObject playerGO;

	[Range(100f, 1000.0f)]
	public float rotateSpeed = 100f;

	public void Update()
	{
		transform.RotateAround(playerGO.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);
	}
}