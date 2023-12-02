using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZebraScript : MonoBehaviour
{
    private GameObject player;
    private RotatingSwords sword;

    void Awake()
    {
        player = GameObject.Find("Player");
        sword = player.transform.GetChild(0).gameObject.GetComponent<RotatingSwords>(); 
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            sword.setRotateSpeed();
            Destroy(gameObject);
        }
    }
}
