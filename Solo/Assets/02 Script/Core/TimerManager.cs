using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private GameObject failUI;
    private void Update()
    {
        if(Time.timeScale == 0)
        {
            failUI.SetActive(true);
            SceneManager.LoadScene("GameStart");
        }
    }
}
