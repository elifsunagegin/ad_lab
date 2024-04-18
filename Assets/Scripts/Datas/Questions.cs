using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="Questions",menuName ="Questions")]
public class Questions : ScriptableObject
{
    [Header("Config")]
    [Header("Questions")]
    public int SelectedCategorie;
    [SerializeField] public string[] questions;
    [SerializeField] public string[] OP1;
    [SerializeField] public string[] OP2;
    [SerializeField] public string[] OP3;
    [SerializeField] public string[] OP4;
    [SerializeField] public Image[] Images;
    [SerializeField] public bool[] TrueOnes;
    [SerializeField] public bool[] SelectedOnes;

    [SerializeField] public int SelectedQuestion;
   
     
  


}
