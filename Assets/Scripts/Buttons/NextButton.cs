using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    [SerializeField] private Image FunfactImage;    
    [SerializeField] TextMeshProUGUI number,Funfactinfo;
    [SerializeField] Questions questions;


    private void Start()
    {
        questions.FunFactindex = 1;
        IndexText();
        FillFunFact();
    }
    public void IndexText()
    {
        number.text = questions.FunFactindex.ToString();

    }
    public void Next()
    {
        questions.FunFactindex++;
        IndexText();
        FillFunFact();


    }
    public void Prev()
    {
        questions.FunFactindex--;
        IndexText();
        FillFunFact();

    }
    public void FillFunFact()
    {
        FunfactImage.sprite = questions.Sprites[questions.funfactstart+ questions.FunFactindex-1];
        Funfactinfo.text = questions.FunFacts[questions.funfactstart + questions.FunFactindex-1];
    }
 }
