using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemtM : MonoBehaviour
{
    public GameObject[] EnemyObjs;
    public Transform[] spawnPoint;

    public float maxSpawnDelay;
    public float curSpawnDelay;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(1f, 5f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        int ranEnemy = Random.Range(1, 1);
        int ranPoint = Random.Range(0, 6);
        Instantiate(EnemyObjs[ranEnemy],
                    spawnPoint[ranPoint].position,
                    spawnPoint[ranPoint].rotation);
    }
}