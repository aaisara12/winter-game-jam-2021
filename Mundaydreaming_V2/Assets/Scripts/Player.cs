using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public deathScreenScript deathScreen;
    public int playerMaxHealth = 100;
    public int playerCurrentHealth;
    public HealthBar healthBar;
    public DialogueManager manager;

    // Start is called before the first frame update
    void Start()
    {
        
        playerCurrentHealth = playerMaxHealth;
        healthBar.setMaxHealth(playerMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void takeDamage (int damage)
    {
        playerCurrentHealth -= damage;
        healthBar.setHealth(playerCurrentHealth);
        GetComponent<Animator>().SetTrigger("Damaged");
        if (playerCurrentHealth == 0)
        {
            deathScreen.setDead();
        }
    }

}
