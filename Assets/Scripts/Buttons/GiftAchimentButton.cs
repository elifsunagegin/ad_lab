using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftAchimentButton : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    public void OpenGift()
    {
        panel.SetActive(true);
    }
    public void CloseGift()
    {
        panel?.SetActive(false);
    }
}
