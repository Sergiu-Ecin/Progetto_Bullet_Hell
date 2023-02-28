using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        //pauseMenuCanvas.gameObject.SetActive(false);
    }

    public void PlayAgain()        
    {
        SceneManager.LoadScene("Level1");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuScreen");
    }

    public void Quit()
    {
        Application.Quit();
    }

    //public void PauseGame()
    //{
    //    if (gameManager.isPaused)
    //    {     
    //        pauseMenuCanvas.gameObject.SetActive(false);

    //        Time.timeScale = 1f;

    //        gameManager.isPaused = false;
    //    }
    //    else
    //    {
    //        pauseMenuCanvas.gameObject.SetActive(true);

    //        Time.timeScale = 0f;

    //        gameManager.isPaused = true;
    //    }
    //}

    //public void ResumeGame()
    //{
    //    pauseMenuCanvas.gameObject.SetActive(false);

    //    Time.timeScale = 1f;

    //    gameManager.isPaused = false;
    //}

}
