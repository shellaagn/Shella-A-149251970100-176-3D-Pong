using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void HowtoPlay()
    {
        SceneManager.LoadScene("HowtoPlay");
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
