using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float tileSize;
    [SerializeField][Range(0, 1)] float scrollSpeed;
    [SerializeField] float viewZone = 1;

    private Transform cameraTransform;
    private Transform[] tiles;
    private int leftIndex, rightIndex;
    private float lastCameraX;

    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraX = cameraTransform.position.x;
        tiles = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            tiles[i] = transform.GetChild(i);
        }

        leftIndex = 0;
        rightIndex = tiles.Length - 1;
    }


    void Update()
    {
        float deltaX = cameraTransform.position.x - lastCameraX;
        transform.position += Vector3.right * (deltaX * scrollSpeed);
        lastCameraX = cameraTransform.position.x;

        if (cameraTransform.position.x < (tiles[leftIndex].transform.position.x + viewZone))
        {
            SwitchLeft();
        }

        if (cameraTransform.position.x > (tiles[rightIndex].transform.position.x - viewZone))
        {
            SwitchRight();
        }
    }

    private void SwitchLeft()
    {
        //sposto il tile a sinistra
        tiles[rightIndex].position = Vector3.right * (tiles[leftIndex].position.x - tileSize);

        //aggiorno gli indici
        leftIndex = rightIndex;
        rightIndex--;

        //controllo che l'indice non sfori la size dell'array
        if (rightIndex < 0)
        {
            rightIndex = tiles.Length - 1;
        }
    }

    private void SwitchRight()
    {
        tiles[leftIndex].position = Vector3.right * (tiles[rightIndex].position.x + tileSize);

        rightIndex = leftIndex;
        leftIndex++;

        if (leftIndex == tiles.Length)
        {
            leftIndex = 0;
        }
    }
}
