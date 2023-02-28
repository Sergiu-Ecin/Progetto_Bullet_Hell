using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float scrollSpeed;

    void Update()
    {
        transform.position = new Vector2(transform.position.x + scrollSpeed * Time.deltaTime, transform.position.y);
    }
}
