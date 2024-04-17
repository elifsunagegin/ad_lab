using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] Questions questions;
    private int Max, Min, Selected,random;

    private void Awake()
    {
        CategoryRage();
        SelectQuestion();
    }

    public void SelectQuestion()
    {
        Selected = GetRandomInt();
        if (questions.TrueOnes[Selected]== false && questions.SelectedOnes[Selected]== false)
        {
            questions.SelectedQuestion = Selected;
        }
        {
            SelectQuestion();
        }
    }
    private int GetRandomInt()
    {
        random = Random.Range(Min, Max+1);
        Debug.Log(random);
        return random;
    }

    private void CategoryRage()
    {
        if (questions.SelectedCategorie == 1)
        {
            Min =1; 
            Max =10;
        }else if (questions.SelectedCategorie == 2)
        {
            Min = 11;
            Max = 20;
        }
        else if (questions.SelectedCategorie == 3)
        {
            Min = 21;
            Max = 30;
        }
        else
        {
            Min = 31;
            Max = 40;
        }
    }

}
