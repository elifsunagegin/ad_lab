using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName ="Questions",menuName ="Questions")]
public class Questions : ScriptableObject
{
    [Header("Config")]
    [Header("Questions")]
    [SerializeField] private string[] questions;
    [SerializeField] private string[] OP1;
    [SerializeField] private string[] OP2;
    [SerializeField] private string[] OP3;
    [SerializeField] private string[] OP4;
    [SerializeField] private bool[] TrueOnes;
    [SerializeField] private bool[] SelectedOnes;
    [SerializeField] private Image[] Images;
   
     
  


}
