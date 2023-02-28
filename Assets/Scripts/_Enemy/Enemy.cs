using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public int damage;
    public float health;
    public int pointValue = 100;

    private GameManager gameManager;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }


    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("hit");
            
            if (gameManager != null)
            {
                gameManager.AddScore(pointValue);
            }
            Destroy(gameObject);
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }
    }

}
