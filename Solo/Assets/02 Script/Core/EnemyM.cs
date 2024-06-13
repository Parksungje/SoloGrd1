using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject EnemyObjs;
    public List<Transform> spawnPoint = new List<Transform>();
    public float maxSpawnDelay;
    public float curSpawnDelay;

    void Update()
    {
        curSpawnDelay += Time.deltaTime;

        if (curSpawnDelay > maxSpawnDelay)
        {
            SpawnEnemy();
            maxSpawnDelay = Random.Range(0.5f, 3f);
            curSpawnDelay = 0;
        }
    }

    void SpawnEnemy()
    {
        //소환될 위치
        int ranPoint = Random.Range(0, 4);
        Instantiate(EnemyObjs,
                    spawnPoint[ranPoint].position,
                    spawnPoint[ranPoint].rotation);
    }
}