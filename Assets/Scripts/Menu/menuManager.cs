using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public string url;
    public void StartQuiz()
    {
        SceneManager.LoadScene(1);
    }

    public void Learn()
    {
        Application.OpenURL(url);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
