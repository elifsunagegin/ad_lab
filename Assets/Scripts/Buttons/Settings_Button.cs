using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avchiments_Button1 : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private int  FunfactCategori;
    [SerializeField] private Questions questions;
    [SerializeField] private NextButton nextButton;

    private void Start()
    {
        questions.FunFactindex = 1;
    }
    public void OpenSettings()
    {
        SetFunFactRange();
        nextButton.IndexText();
        nextButton.FillFunFact();
        panel.SetActive(true);
    }
    public void CloseSettings()
    {
        questions.FunFactindex = 1;
        panel?.SetActive(false);
    }
    private void SetFunFactRange()
    {
        if (FunfactCategori==1)
        { 
         questions.funfactstart= questions.Categoriy1First;
         questions.funfactfinal= questions.Categoriy1Last;
         }
        else if (FunfactCategori == 2) 
        {
            questions.funfactstart = questions.Categoriy2First;
            questions.funfactfinal = questions.Categoriy2Last;
        }
        else if (FunfactCategori == 3)
        {
            questions.funfactstart = questions.Categoriy3First;
            questions.funfactfinal = questions.Categoriy3Last;
        }
        else if (FunfactCategori == 4)
        {
            questions.funfactstart = questions.Categoriy4First;
            questions.funfactfinal = questions.Categoriy4Last;
        }
    }
}
