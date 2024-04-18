using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CategoriesButtons : MonoBehaviour
{
    [SerializeField] Questions questions;
    public void Categorie1()
    {
        questions.SelectedCategorie = 1;
        SceneManager.LoadScene("QuestionScreen");
    }
    public void Categorie2()
    {
        questions.SelectedCategorie = 2;
        SceneManager.LoadScene("QuestionScreen");
    }
    public void Categorie3()
    {
        questions.SelectedCategorie = 3;
        SceneManager.LoadScene("QuestionScreen");
    }
    public void Categorie4()
    {
        questions.SelectedCategorie = 4;
        SceneManager.LoadScene("QuestionScreen");
    }
}
