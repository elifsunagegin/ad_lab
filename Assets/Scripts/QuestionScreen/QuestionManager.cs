
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI button1, button2, button3, button4;
    [SerializeField] private TextMeshProUGUI question_text;
    

    [SerializeField] Questions questions;
    private int Max, Min, Selected,random;

    private bool[] bools = { false, false, false, false };
    private bool[] Selecteds = { false, false, false, false };
    private void Awake()
    {
        CategoryRage();
        questions.SelectedQuestion = SelectQuestion(); 
        FillQuestions();
    }

    public void ReFillQuestions()
    {
        questions.SelectedQuestion = SelectQuestion();
        FillQuestions();
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

        questions.SelectedOnes[Selected] = true;
        return Selected;        
    }
    private int GetRandomInt()
    {
        random = Random.Range(Min,Max);
        Debug.Log(random);
        return random;
    }
    public void FillQuestions()
    {
        for (int i = 0; i < bools.Length; i++)
        {
            Selecteds[i] = bools[i];
        }

        image.sprite = questions.Sprites[Selected];
        image.SetNativeSize();
        button1.text = GetOp();
        button2.text = GetOp();
        button3.text = GetOp();  
        button4.text = GetOp();
        question_text.text = questions.questions[Selected];
    }
    private void CategoryRage()
    {
        if (questions.SelectedCategorie == 1)
        {
            Min =questions.Categoriy1First; 
            Max =questions.Categoriy1Last;
        }else if (questions.SelectedCategorie == 2)
        {
            Min = questions.Categoriy2First;
            Max = questions.Categoriy2Last;
        }
        else if (questions.SelectedCategorie == 3)
        {
            Min = questions.Categoriy3First;
            Max = questions.Categoriy3Last;
        }
        else
        {
            Min = questions.Categoriy4First;
            Max = questions.Categoriy4Last;
        }
    }

    public string GetOp()
    {
        int i = Random.Range(0, 4);
        while (Selecteds[i] == true)
        {
            i = Random.Range(0, 4);
        }
        Selecteds[i] = true;
        if (i == 0) { return questions.OP1[Selected]; }
        else if (i == 1) { return questions.OP2[Selected]; } 
        else if (i == 2) { return questions.OP3[Selected]; }
        else { return questions.OP4[Selected]; }
    }
}
