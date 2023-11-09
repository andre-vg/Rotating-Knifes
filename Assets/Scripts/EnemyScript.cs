using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Range(0f, 10f)]
    public float enemySpeed = 1f;
    public GameObject player;

    //Function to start follow player
    public void Awake(){
        player = GameObject.Find("Player");
    }
    public void Update()
    {
        //Get player position
        Vector3 playerPos = player.transform.position;

        //Move enemy to player position
        transform.position = Vector3.MoveTowards(transform.position, playerPos, Time.deltaTime * enemySpeed);
    }
}
