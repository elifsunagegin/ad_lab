using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avchiments_Button1 : MonoBehaviour
{
    [SerializeField] private GameObject panel;
   public void OpenSettings()
    {
        panel.SetActive(true);
    }
    public void CloseSettings()
    {
        panel?.SetActive(false);
    }
}
