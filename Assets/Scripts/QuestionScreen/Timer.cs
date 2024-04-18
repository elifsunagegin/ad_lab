using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float timer;
    [SerializeField] private float MaxTime;

    [SerializeField]private TextMeshProUGUI TimeUI;

    private void Awake()
    {
        TimeUI = GetComponent<TextMeshProUGUI>();
        timer = MaxTime;
    }
    private void Update()
    {

        Timer();
    }

    private void Timer()
    {
        if(timer<=0) return;
        TimeUI.text = timer.ToString("F0");
        timer -= Time.deltaTime;
    } 
}
