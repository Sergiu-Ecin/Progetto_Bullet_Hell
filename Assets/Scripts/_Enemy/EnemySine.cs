using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySine : MonoBehaviour
{
    public float amplitude = 2;
    public float frequency = 0.5f;
    public float moveSpeed = 1f;

    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        pos.x -= moveSpeed * Time.deltaTime;
        pos.y = sin;

        transform.position = pos;
    }

}

