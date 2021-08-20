using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool gameP;
    public GameObject menuP;

    private void Start()
    {
        menuP.SetActive(false);
    }

    public void SwitchPause()
    {
        if (gameP)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        menuP.SetActive(false);
        Time.timeScale = 1;
        gameP = false;
    }

    public void Pause()
    {
        menuP.SetActive(true);
        Time.timeScale = 0;
        gameP = true;
    }

    //____________________________________________________________________________

    public void ReturnMenu()
    {
        SceneManager.LoadScene(1);
    }

    public Button[] nivel;

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
