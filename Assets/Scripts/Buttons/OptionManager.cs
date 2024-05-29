using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private Questions questions;
    [SerializeField] private Timer timer;
    [SerializeField] private QuestionManager questionManager;   
    [SerializeField] private TextMeshProUGUI OPText;
    public void Control()
    {
        if(OPText.text == questions.OP1[questions.SelectedQuestion]){ TrueOp(); }
        else { FalseOp(); }
    }
    private void FalseOp()
    {
        timer.FalseOP();
        questionManager.ReFillQuestions();
    }
    private void TrueOp()
    {
        questions.TrueOnes[questions.SelectedQuestion] = true;
       if (questionManager.ControlQuestions()) timer.OpenResultPanel();
        timer.TrueOP();
        questionManager.ReFillQuestions();
    }
}
