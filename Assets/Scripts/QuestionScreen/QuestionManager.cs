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

    private void Awake()
    {
        CategoryRage();
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
        image.sprite = questions.Sprites[Selected];
        button1.text = questions.OP1[Selected];
        button2.text = questions.OP2[Selected];
        button3.text = questions.OP3[Selected];
        button4.text = questions.OP4[Selected];
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

}
