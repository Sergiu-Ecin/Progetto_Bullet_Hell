using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int currentLevel = 1;
    public int maxLevel = 3;
    public Text scoreText;
    public Text healthText;
    public Player player;

    //public bool isPaused = false;

    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        healthText.text= "Health: " + player.health.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        healthText.text = "Health: " + player.health.ToString();
    }

    // Metodo per incrementare il punteggio
    public void AddScore(int amount)
    {
        score += amount;

        if (score >= 1000 && currentLevel == 1)
        {
            currentLevel = 2;
            SceneManager.LoadScene("Level2");
        }
        else if (score >= 1000 && currentLevel == 2)
        {
            currentLevel = 3;
            SceneManager.LoadScene("Level3");
        }
        else if (score >= 600 && currentLevel == 3)
        {
            SceneManager.LoadScene("WinScreen");
            Debug.Log("hai vinto");
        }
    }
}