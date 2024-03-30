using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Avchiments_Button : MonoBehaviour
{
    public void Open_Achievements()
    {
        SceneManager.LoadScene("Achievements");
    }
}
