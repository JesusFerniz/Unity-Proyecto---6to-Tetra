using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGamePrimerNivel()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayGamePrimerNivel2()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayGamePrimerNivel3()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
