using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatoScript : MonoBehaviour
{

    private PlayerController player;

    void Awake()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            player.healPlayer();
            Destroy(gameObject);
        }
    }
}
