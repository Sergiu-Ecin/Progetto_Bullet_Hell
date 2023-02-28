using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Prefab degli enemy da spawnare
    public Transform[] spawnPoints; // Elenco dei punti di spawn
    public float spawnInterval = 1.0f; // Intervallo di tempo tra uno spawn e l'altro
    public float spawnDuration = 10.0f; // Durata del spawn per ogni tipo di nemico

    private float timer = 0.0f;
    private int currentEnemyType = 0;
    private float currentEnemyDuration = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        // Verifica se è il momento di spawnare un nuovo enemy
        if (timer >= spawnInterval)
        {
            timer = 0.0f;

            // Scegli casualmente uno dei punti di spawn
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Spawnare l'enemy del tipo corrente nel punto di spawn selezionato
            GameObject enemyPrefab = enemyPrefabs[currentEnemyType];
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            // Aggiorna la durata dell'enemy corrente
            currentEnemyDuration += spawnInterval;

            // Se la durata dell'enemy corrente è finita, passa al prossimo tipo di nemico
            if (currentEnemyDuration >= spawnDuration)
            {
                currentEnemyType = (currentEnemyType + 1) % enemyPrefabs.Length;
                currentEnemyDuration = 0.0f;
            }
        }
    }
}
