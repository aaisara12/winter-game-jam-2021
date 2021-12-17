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

    }

    void takeDamage (int damage)
    {
        toastCurrentHealth -= damage;
        healthBar.setHealth(toastCurrentHealth);
        healthMonitor.monitor.toastLowHealth(toastCurrentHealth);
    }
}
