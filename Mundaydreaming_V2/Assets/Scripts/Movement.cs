using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerInput = Input.GetAxisRaw("Horizontal");

        Vector2 targetVelocity = playerInput * Vector2.right * speed;

        // TODO: Smooth damp current velocity up to target velocity
        Vector2 currentVelocity = targetVelocity;

        transform.Translate(currentVelocity * Time.deltaTime);
    }
}
