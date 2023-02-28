using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Enemy enemy;
    public float speed;
    private Rigidbody2D rb;
    public float damage;
    

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        rb.velocity = transform.right*speed ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
