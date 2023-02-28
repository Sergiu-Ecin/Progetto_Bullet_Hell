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
        // decrement the fire timer
        fireTimer -= Time.deltaTime;

        // if the fire timer is less than or equal to zero, fire the projectile
        if (fireTimer <= 0.0f)
        {
            FireProjectile();
            fireTimer = 1.0f / fireRate;
        }
    }

    void FireProjectile()
    {
        // instantiate the projectile at the current position of the enemy
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // set the direction of the projectile to the left
        Vector3 direction = Vector3.left;

        // set the velocity of the projectile based on the direction and the speed
        projectile.GetComponent<Rigidbody2D>().velocity = direction * 10.0f;
    }
}
