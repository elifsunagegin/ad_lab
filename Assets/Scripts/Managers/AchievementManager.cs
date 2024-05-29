using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementManager : MonoBehaviour
{
    [SerializeField]
    PlayerDatas PlayerDatas;
    [SerializeField] Image Lock;


    public void Start()
    {
        if(PlayerDatas.PlayTime > 15)
        {
            Lock.gameObject.SetActive(false);
        }
        
    }
}
