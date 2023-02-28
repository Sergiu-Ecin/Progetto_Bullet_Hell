using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarBackground;
    public Image healthBarFill;
    public float health;

    
    void Start()
    {
        health = 100f;
    }

    
    void Update()
    {
        healthBarFill.fillAmount = health / 100f;
    }

    
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
