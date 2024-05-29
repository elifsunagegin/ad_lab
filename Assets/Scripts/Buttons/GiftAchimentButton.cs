using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftAchimentButton : MonoBehaviour
{

    [SerializeField] private int Index;
    [SerializeField] private Questions questions;

    [SerializeField] private GameObject panel;
    public void OpenGift()
    {
        questions.Achievements_Index = Index;
        panel.SetActive(true);
    }
    public void CloseGift()
    {
        panel?.SetActive(false);
    }

    
}
