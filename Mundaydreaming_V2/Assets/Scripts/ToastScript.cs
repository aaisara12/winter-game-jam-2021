using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastScript : MonoBehaviour
{
    public deathScreenScript victoryScreen;
    public int toastMaxHealth = 100;
    public int toastCurrentHealth;
    public HealthBar healthBar;
    public DialogueManager manager;
    private bool played0, played1 = false;

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
            takeDamage(10);
        }
        if(toastCurrentHealth == 20)
        {
            if (played0 == false)
                manager.StartDialogue("Toasty", 2);
            played0 = true;
            
        }
        else if (toastCurrentHealth == 10)
        {
            if (played1 == false)
                manager.StartDialogue("Toasty", 3);
            played1 = true;
            takeDamage(5);
        }

    }

    void takeDamage (int damage)
    {
        toastCurrentHealth -= damage;
        healthBar.setHealth(toastCurrentHealth);
        if (toastCurrentHealth == 0)
        {
            Time.timeScale = 0f;
            victoryScreen.setDead();
        }
    }
}
