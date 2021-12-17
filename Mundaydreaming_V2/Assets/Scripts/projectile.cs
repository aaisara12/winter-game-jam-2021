using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    [SerializeField] int damage = 10;
    [SerializeField] float lifetimeSeconds = 5;
    float timeStart = 0;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Time.time - timeStart >= lifetimeSeconds)
            Destroy(this.gameObject);
        */
        //transform.Translate(transform.right * Time.deltaTime * GetComponent<Rigidbody2D>().velocity);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        hitInfo.GetComponent<PlayerStandIn>()?.takeDamage(damage);
        Destroy(this.gameObject);
    }
}
