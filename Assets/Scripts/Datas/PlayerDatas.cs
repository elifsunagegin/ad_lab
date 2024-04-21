using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDatas", menuName = "Player Datas")]
public class PlayerDatas :  ScriptableObject
{
    [Header("Config")]
    [SerializeField] float TrueNumber;
    [SerializeField] float FalseNumber;
    [SerializeField] string PlayerName;

    public float PlayTime;
}
