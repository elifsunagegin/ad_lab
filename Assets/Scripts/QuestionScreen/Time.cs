using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Time : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private float Time;

    private TextMeshPro time;

    private void Awake()
    {

        Deltatim
        time = GetComponent<TextMeshPro>();
    }
    private void Update()
    {
       Intager time.text -= Time
    }
}
