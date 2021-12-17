using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 3;

    // Ideally, we would want the boundaries to be calculated based on screen position of the player (do so if time permits)
    [SerializeField] Transform frontBoundary;
    [SerializeField] Transform rearBoundary;


    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxisRaw("Horizontal");

        Vector2 targetVelocity = playerInput * Vector2.right * speed;

        // TODO: Smooth damp current velocity up to target velocity
        Vector2 currentVelocity = targetVelocity;
        
        Vector3 desiredChange = (currentVelocity * Time.deltaTime);

        if((desiredChange + transform.position).x <= frontBoundary.position.x &&
           (desiredChange + transform.position).x >= rearBoundary.position.x)
            transform.Translate(currentVelocity * Time.deltaTime);
    }
}
