using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingToaster : MonoBehaviour
{
    public GameObject projectile;
    public float launchForce;
    public Transform shotPoint;
    public float timeSinceLastPew = 0;
    public float pewDelayTime = 4;
    public float heightAbovePlayer = 20;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        Vector2 originPosition = transform.position;
        Vector2 playerPosition = player.transform.position;
        playerPosition = new Vector2(playerPosition.x, playerPosition.y + heightAbovePlayer);
        Vector2 direction = playerPosition - originPosition;
        transform.right = -direction;
        Shoot();
    }

    void Shoot()
    {
        if (timeSinceLastPew >= pewDelayTime)
        {
            GameObject newProjectile = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
            newProjectile.GetComponent<Rigidbody2D>().velocity = -1* transform.right * launchForce;
            transform.position = new Vector3(transform.position.x, transform.position.y, 70);
            timeSinceLastPew = 0;
        }
        else {
            timeSinceLastPew += Time.deltaTime;
        }
    }
}
