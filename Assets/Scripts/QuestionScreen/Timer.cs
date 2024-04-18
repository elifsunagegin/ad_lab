using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float clock;
    [SerializeField] private float MaxTime;

    [SerializeField]private TextMeshProUGUI TimeUI;

    private void Awake()
    {
        TimeUI = GetComponent<TextMeshProUGUI>();
        clock = MaxTime;
    }
    private void Update()
    {
        Clock();
    }

    private void Clock()
    {
        if(clock<=0) return;
        TimeUI.text = clock.ToString("F0");
        clock -= Time.deltaTime;
    } 
}
