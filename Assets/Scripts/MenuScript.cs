using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        StartGame();
    }

    public void ExitFromGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
