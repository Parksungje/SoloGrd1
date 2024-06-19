using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public float time = 60;
    private float selectCountdown;

    private void Start()
    {
        selectCountdown = time;
    }

    private void Update()
    {
        TimerStart();
    }

    public void TimerStart()
    {
        if (Mathf.Floor(selectCountdown) <= 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            selectCountdown -= Time.deltaTime;
            timerText.text = Mathf.Floor(selectCountdown).ToString();
        }
    }
}
