using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonmanager : MonoBehaviour
{
    public void IntroMenu()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void HighScoreMenu()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void GameMenu()
    {
        SceneManager.LoadScene("3Game");
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void QuitGame()
    {
        Debug.Log("You Left");
        Application.Quit();
    }
}
