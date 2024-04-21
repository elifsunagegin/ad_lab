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
        questions.SelectedQuestion = SelectQuestion(); 
    }

    private bool isValidQuestion(int selected)
    {
        return questions.TrueOnes[Selected] == false && questions.SelectedOnes[Selected] == false;
    }
    public int SelectQuestion()
    {
        do
        {
            Selected = GetRandomInt();
        } while (!isValidQuestion(Selected));

        return Selected;        
    }
    private int GetRandomInt()
    {
        random = Random.Range(Min,Max);
        Debug.Log(random);
        return random;
    }

    private void CategoryRage()
    {
        if (questions.SelectedCategorie == 1)
        {
            Min =1; 
            Max =11;
        }else if (questions.SelectedCategorie == 2)
        {
            Min = 11;
            Max = 21;
        }
        else if (questions.SelectedCategorie == 3)
        {
            Min = 21;
            Max = 31;
        }
        else
        {
            Min = 31;
            Max = 41;
        }
    }

}
