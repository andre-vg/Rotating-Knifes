using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
   public Transform player;
   public GameObject[] prefabs;

   [Range (1, 50)]
   public int maximumToSpawn = 6;
   [Range (1, 60)]
   public int spawnTime = 5;
   [Range(5, 60)]
   public float distanceToSpawn = 15f;

   private int totalOnMap = 0;

   public void Start()
   {
        StartCoroutine(Spawn());
   }

   public void IDied()
   {
        totalOnMap -= 1;
   }

   public IEnumerator Spawn()
   {
        while (true)
        {
            if (totalOnMap < maximumToSpawn) // Spawner
            {
                if (prefabs.Length == 1)
                {
                    GameObject temp = Instantiate(prefabs[0], GetRandomPlaceAroundPlayer(), Quaternion.identity, this.transform);
                    totalOnMap += 1;
                }
                else if (totalOnMap < maximumToSpawn)
                {
                    int randomPrefab = Random.Range(0, prefabs.Length); //randomize prefab to be instantiated
                    GameObject temp = Instantiate(prefabs[randomPrefab], GetRandomPlaceAroundPlayer(), Quaternion.identity, this.transform);
                    totalOnMap += 1;
                }
            }

            yield return new WaitForSeconds((float)spawnTime);
        }
   }

   public Vector3 GetRandomPlaceAroundPlayer()
   {    
        float x = player.position.x;
        if (x <= 0)
        {
            x -= -Random.Range(-distanceToSpawn, distanceToSpawn);
        }
        else
        {
            x += Random.Range(-distanceToSpawn, distanceToSpawn);
        }

        // Y
        float y = player.position.y;

        if (y <= 0)
        {
            y -= -Random.Range(-distanceToSpawn, distanceToSpawn);
        }
        else
        {
            y += Random.Range(-distanceToSpawn, distanceToSpawn);
        }
        return new Vector3(x, y, 0);
   }
}
