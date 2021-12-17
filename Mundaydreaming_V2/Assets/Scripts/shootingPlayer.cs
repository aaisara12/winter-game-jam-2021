using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingPlayer : MonoBehaviour
{
    public GameObject projectile;
    public float launchForce;
    public Transform shotPoint;
    
    // Update is called once per frame
    void Update()
    {
        Vector2 originPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - originPosition;
        transform.right = direction;

        if (Input.GetMouseButtonDown(0)) {
            Shoot();
        }
    }
    
    void Shoot() {
        GameObject newProjectile = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
        newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        transform.position = new Vector3(transform.position.x, transform.position.y, 70);
    }
    
}
