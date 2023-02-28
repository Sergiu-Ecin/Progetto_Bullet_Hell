using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireRate = 1.0f;

    private float fireTimer = 0.0f;

    void Update()
    {
        
        fireTimer -= Time.deltaTime;

        
        if (fireTimer <= 0.0f)
        {
            FireProjectile();
            fireTimer = 1.0f / fireRate;
        }
    }

    void FireProjectile()
    {
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        
        Vector3 direction = Vector3.left;

        
        projectile.GetComponent<Rigidbody2D>().velocity = direction * 10.0f;
    }
}
