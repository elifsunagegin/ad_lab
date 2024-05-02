using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CaregoryManager : MonoBehaviour
{
    [SerializeField] Questions questions;
    [SerializeField] TextMeshProUGUI CatTrue1, CatAll1, CatTrue2, CatAll2, CatTrue3, CatAll3, CatTrue4, CatAll4;
    private void Start()
    {
        SetAll();
        Settrues();
    }
    private void SetAll()
    {
        CatAll1.text = questions.Categoriy1Last.ToString();
        CatAll2.text = (questions.Categoriy2Last-questions.Categoriy1Last).ToString();
        CatAll3.text = (questions.Categoriy3Last - questions.Categoriy2Last).ToString();
        CatAll4.text = (questions.Categoriy4Last - questions.Categoriy3Last).ToString();
    }
    private void Settrues()
    {
        CatTrue1.text = CountTrues(questions.Categoriy1First, questions.Categoriy1Last).ToString("F0");
        CatTrue2.text = CountTrues(questions.Categoriy2First, questions.Categoriy2Last).ToString("F0");
        CatTrue3.text = CountTrues(questions.Categoriy3First, questions.Categoriy3Last).ToString("F0");
        CatTrue4.text = CountTrues(questions.Categoriy4First, questions.Categoriy4Last).ToString("F0");
    }
    private int CountTrues(int first,int last) 
    {
        int trues=0;
        for (int i = first; i < last; i++) 
        {
            if (questions.TrueOnes[i]==true) trues++;   
        }
        return trues;
    }

    private void SetAllFalse()
    {
        for(int i = questions.Categoriy1First; i< questions.Categoriy1Last;i++) 
        {
            questions.SelectedOnes[i] = false;
        }
    }

}
