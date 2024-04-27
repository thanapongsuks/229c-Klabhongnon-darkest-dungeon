using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level 1");
    }
    
    public void Credit()
    {
        SceneManager.LoadSceneAsync("Credit");
    }
    
    public void Menu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("The button is working");
    }

    public void Win()
    {
        SceneManager.LoadSceneAsync("WIN");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
