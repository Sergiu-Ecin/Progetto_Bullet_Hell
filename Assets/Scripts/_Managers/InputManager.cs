using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public Transform Player;
    [SerializeField] float playerSpeed = 3;
    [SerializeField] float boundaryHeight = 3.10f;
    //public Canvas pauseMenuCanvas;
    private GameManager gameManager;
    private ScreenManager screenManager;


    Vector2 pOldPosition = Vector2.zero;


    void Update()
    {
        MovePlayer();
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    gameManager.isPaused= true;
        //    screenManager.PauseGame();
        //}

    }

    public void MovePlayer()
    {
        float pVMove = Input.GetAxis("Vertical");
        Player.Translate(Vector3.up * pVMove * playerSpeed * Time.deltaTime);
        if (Player.position.y > 3.10f)
        {
            Player.position = new Vector2(Player.position.x, 3.10f);
        }
        else if (Player.position.y < -3.10f)
        {
            Player.position = new Vector2(Player.position.x, -3.10f);
        }

        if (Mathf.Abs(Player.position.y) > boundaryHeight)
        {
            Player.position = new Vector2(Player.position.x, Mathf.RoundToInt(pOldPosition.y));
            Debug.Log(pOldPosition);
        }

        pOldPosition = Player.position;
    }
}
