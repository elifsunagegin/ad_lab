using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName ="Questions",menuName ="Questions")]
public class Questions : ScriptableObject
{
    [Header("Config")]
    [Header("Questions")]

    [SerializeField] public int SelectedCategorie;
    [SerializeField] public int SelectedQuestion;
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
