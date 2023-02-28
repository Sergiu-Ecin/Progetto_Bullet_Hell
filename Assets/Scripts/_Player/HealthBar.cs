using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarBackground; // l'immagine di sfondo della barra della vita
    public Image healthBarFill; // l'immagine di riempimento della barra della vita
    public float health; // la vita del giocatore

    // Impostare la vita iniziale del giocatore
    void Start()
    {
        health = 100f;
    }

    // Aggiornare la barra della vita in base alla vita del giocatore
    void Update()
    {
        healthBarFill.fillAmount = health / 100f;
    }

    // Ridurre la vita del giocatore quando viene colpito
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
