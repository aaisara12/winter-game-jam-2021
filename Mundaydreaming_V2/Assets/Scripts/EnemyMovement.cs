using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] float movementRange = 5;
    [SerializeField] float movesPerSecond = 0.5f;

    float startPosition;
    float currentPosition;
    float targetDelta = 0;  // How far away from the start position should this enemy move?

    float lastMoveTime = 0;

    void Awake()
    {
        startPosition = transform.position.x;
    }


    // Update is called once per frame
    void Update()
    {
        currentPosition = transform.position.x;

        if(Mathf.Abs((currentPosition - startPosition) - targetDelta) > 0.5f)
        {
            transform.Translate(((startPosition + targetDelta) - currentPosition) * Vector3.right * speed * Time.deltaTime);
        }

        if(Time.time - lastMoveTime > (1/movesPerSecond))
        {
            targetDelta = Random.Range(-movementRange, movementRange);
            lastMoveTime = Time.time;
        }
    }
}
