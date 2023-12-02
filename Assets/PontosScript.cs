using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PontosScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timerText;
    private float startTime;

    void Awake()
    {
        timerText = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        timerText.text = "Pontos: " + (int)Time.timeSinceLevelLoad;
    }
}
