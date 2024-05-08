using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FunFactButton : MonoBehaviour
{
    public void FunFact()
    {
        SceneManager.LoadScene("FunFacts");
    }
}
