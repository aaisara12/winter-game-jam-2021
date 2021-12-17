using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeater : MonoBehaviour
{
    [SerializeField] float parallax = 0.5f;
    float length, startPos;
    Camera gameCamera;

    void Awake()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        startPos = transform.position.x;

        gameCamera = Camera.main;
    }

    void FixedUpdate()
    {
        float distanceTraveledByBackground = gameCamera.transform.position.x * (1 - parallax);

        if(distanceTraveledByBackground >= startPos + length)
            startPos += length;

        transform.position = new Vector3(startPos + gameCamera.transform.position.x * parallax, transform.position.y, transform.position.z);
    }
}
