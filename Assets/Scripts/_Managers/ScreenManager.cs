using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    //public Canvas pauseMenuCanvas;
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
    //        // Disabilita il menu di pausa
    //        pauseMenuCanvas.gameObject.SetActive(false);

    //        // Riprende il gioco
    //        Time.timeScale = 1f;

    //        // Il gioco non è più in pausa
    //        gameManager.isPaused = false;
    //    }
    //    else
    //    {
    //        // Altrimenti, se il gioco non è in pausa
    //        // Abilita il menu di pausa
    //        pauseMenuCanvas.gameObject.SetActive(true);

    //        // Mette in pausa il gioco
    //        Time.timeScale = 0f;

    //        // Il gioco è ora in pausa
    //        gameManager.isPaused = true;
    //    }
    //}

    //public void ResumeGame()
    //{
    //    pauseMenuCanvas.gameObject.SetActive(false);

    //    // Riprende il gioco
    //    Time.timeScale = 1f;

    //    // Il gioco non è più in pausa
    //    gameManager.isPaused = false;
    //}

}
