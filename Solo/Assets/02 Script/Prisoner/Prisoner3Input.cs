using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prisoner3Input : MonoBehaviour
{
    private int totalEnemyCount;
    static private int enemyCount;
    private void Awake()
    {
        totalEnemyCount = 3;
        enemyCount = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Light"))
        {
            Destroy(gameObject);
            enemyCount++;
            print(enemyCount);
            if (totalEnemyCount == enemyCount)
            {
                SceneManager.LoadScene("Stage4");
            }


        }
    }
}
