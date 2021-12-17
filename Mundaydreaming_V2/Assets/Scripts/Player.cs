using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int playerMaxHealth = 100;
    public int playerCurrentHealth;
    public HealthBar healthBar;
    public DialogueManager manager;
    private bool played0, played1 = false;

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
            if (played0 == false)
                manager.StartDialogue("Norman", 0);
            played0 = true;
        }
        else if (playerCurrentHealth == 10)
        {
            if (played1 == false)
                manager.StartDialogue("Norman", 1);
            played1 = true;
        }
    }

    void takeDamage (int damage)
    {
        playerCurrentHealth -= damage;
        healthBar.setHealth(playerCurrentHealth);
    }

}
