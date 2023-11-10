using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject cubePrefab;
    [Range(1f, 10f)]
    public int spawnTime = 10;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    public IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            //Instantiate inside spawner
            Instantiate(cubePrefab, transform.position, Quaternion.identity, this.transform);
        }
    }
}