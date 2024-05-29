using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="Questions",menuName ="Questions")]
public class Questions : ScriptableObject
{
    [Header("Config")]
    [Header("Questions")]

    [SerializeField] public float Achievements_Index;
    [SerializeField] public string[] Achievements_String;
    [SerializeField] public int SelectedCategorie;
    [SerializeField] public int SelectedQuestion;
    [SerializeField] public string[] questions;
    [SerializeField] public string[] OP1;
    [SerializeField] public string[] OP2;
    [SerializeField] public string[] OP3;
    [SerializeField] public string[] OP4;
    [SerializeField] public Sprite[] Sprites;
    [SerializeField] public bool[] TrueOnes;
    [SerializeField] public bool[] SelectedOnes;
    [SerializeField] public int Categoriy1First, Categoriy1Last, Categoriy2First, Categoriy2Last, Categoriy3First, Categoriy3Last, Categoriy4First, Categoriy4Last;






}
