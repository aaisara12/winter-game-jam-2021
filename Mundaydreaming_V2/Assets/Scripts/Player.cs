using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int playerMaxHealth = 100;
    public int playerCurrentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
        playerCurrentHealth = playerMaxHealth;
        healthBar.setMaxHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);
        }
        if(playerCurrentHealth == 20)
        {
            healthMonitor.monitor.lowHealthIndicator(2);
            Debug.Log("player's health is low: 20%");
            
        }
        else if (playerCurrentHealth == 10)
        {
            healthMonitor.monitor.lowHealthIndicator(1);
            Debug.Log("player health is low: 10%");
        }
    }

    void takeDamage (int damage)
    {
        playerCurrentHealth -= damage;
        healthBar.setHealth(playerCurrentHealth);
    }

}
