using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private Questions questions;
    [SerializeField] private Timer timer;
    [SerializeField] private QuestionManager questionManager;   
    private TextMeshProUGUI OPText;

    private void Awake()
    {
        OPText = GetComponent<TextMeshProUGUI>();
    }
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
        timer.TrueOP();
        questionManager.ReFillQuestions();
    }
}
