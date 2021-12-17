using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float lifetimeSeconds = 5;
    float timeStart = 0;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = Time.time;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        trackMovement();
        if (Time.time - timeStart >= lifetimeSeconds)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        hitInfo.GetComponent<PlayerStandIn>()?.takeDamage(damage);
        Destroy(this.gameObject);
    }

    void trackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
