using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalEnemyCount; //없애야하는 적 수
    public int stage; //스테이지 번호

    void Awake()
    {
        stage = 0;
    }
}
