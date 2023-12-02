using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    void Awake()
    {
        timerText = GetComponent<Text>();
    }

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        //make a timer that shows only seconds until we make to 60 seconds and than it will show minutes and seconds
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        if (minutes.Length == 1)
        {
            minutes = "0" + minutes;
        }
        if (seconds.Length == 1)
        {
            seconds = "0" + seconds;
        }

        if (t < 59)
        {
            timerText.text = seconds;
        }
        else
        {
            timerText.text = minutes + ":" + seconds;
        }
    }
}
