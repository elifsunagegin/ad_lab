using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] PlayerDatas playerDatas;

    public void Kadoyudusur()
    {
        playerDatas.Kado = "Benim Adým kadriye ";   }
    public void Open_Categories()
    {
        SceneManager.LoadScene("Categories"); 
    }
}
