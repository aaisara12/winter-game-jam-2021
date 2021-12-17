using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastScript : MonoBehaviour
{
    
    public int toastMaxHealth = 100;
    public int toastCurrentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
        toastCurrentHealth = toastMaxHealth;
        healthBar.setMaxHealth(toastMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y) && toastCurrentHealth > 0)
        {
            takeDamage(5);
        }
        if(toastCurrentHealth == 20)
        {
            healthMonitor.monitor.toastLowHealth(2);
            Debug.Log("toast's health is low: 20%");
            
        }
        else if (toastCurrentHealth == 10)
        {
            healthMonitor.monitor.toastLowHealth(1);
            Debug.Log("toast's health is low: 10%");
        }

    }

    void takeDamage (int damage)
    {
        toastCurrentHealth -= damage;
        healthBar.setHealth(toastCurrentHealth);
    }
}
