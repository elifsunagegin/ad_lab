using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Questions",menuName ="Questions")]
public class Questions : ScriptableObject
{
    [Header("Config")]
    [SerializeField] float QuestionNumber;
}
