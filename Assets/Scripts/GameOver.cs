using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    // 0 = Main Menu.
    // 1 = Game
    // 2 = End Screen.
    // 3 = Character Customization.
    // 4 = Achievemenets
    // 5 = Settlement

    private bool isPaused = false;

    #region Buttons

    public void TryAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    public void CharacterCus()
    {
        SceneManager.LoadScene(3);
    }

    public void Settlement()
    {
        SceneManager.LoadScene(5);
    }

    public void Achievemenets()
    {
        SceneManager.LoadScene(4);
    }

    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
    }
}
