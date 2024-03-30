using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionScreen : MonoBehaviour
{
    public void Open_Questions()
    {
        SceneManager.LoadScene("QuestionScreen");
    }
}
