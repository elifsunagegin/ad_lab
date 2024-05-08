using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI number;

    private int num ;
    private void Start()
    {
        num = 1;
        number.text = num.ToString();
    }
    public void Next()
    {
        num++;
        number.text = num.ToString();

    }
    public void Prev()
    {
        num--;
        number.text = num.ToString();

    }
}
