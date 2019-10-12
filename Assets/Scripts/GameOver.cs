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

    private bool _isPaused = false;

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
        if (_isPaused)
        {
            Time.timeScale = 1;
            _isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            _isPaused = true;
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
