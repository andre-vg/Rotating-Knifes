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

	//Just overlapped a collider 2D
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "Player")
		{
			Debug.Log("Player hit by rotating sword");
		}
		if (collision.gameObject.name == "Enemy")
		{
			Destroy(collision.gameObject);
		}
		if (collision.gameObject.name == "Enemy(Clone)")
		{
			Destroy(collision.gameObject);
		}	
	}
}