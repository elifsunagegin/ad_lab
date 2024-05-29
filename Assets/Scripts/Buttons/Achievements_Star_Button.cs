using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Achievements_Star_Button : MonoBehaviour
{

    [SerializeField] private GameObject Panel;
    public void PanelOpening()
    { 
            Panel.SetActive(true);
        }
    public void PanelClosing()
    {
        Panel?.SetActive(false);
    }
    
}
