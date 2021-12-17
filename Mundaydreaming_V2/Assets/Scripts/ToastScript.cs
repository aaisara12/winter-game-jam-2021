using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToastScript : MonoBehaviour
{
    
    public int toastMaxHealth = 100;
    public int toastCurrentHealth;
    public HealthBar healthBar;
    public DialogueManager manager;
    private bool played100, played80, played60, played40, played20 = false;

    // Start is called before the first frame update
    void Start()
    {
        
        toastCurrentHealth = toastMaxHealth;
        healthBar.setMaxHealth(toastMaxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            takeDamage(10);
        }
        switch (toastCurrentHealth)
        {
            case 100:
                if (played100 == false)
                    manager.StartDialogue(0, 1);
                played100 = true;
                break;
            case 80:
                if (played80 == false)
                    manager.StartDialogue(2, 3);
                played80 = true;
                break;
            case 60:
                if (played60 == false)
                    manager.StartDialogue(4, 6);
                played60 = true;
                break;
            case 40:
                if (played40 == false)
                    manager.StartDialogue(7, 8);
                played40 = true;
                break;
            case 20:
                if (played20 == false)
                    manager.StartDialogue(9, 11);
                played20 = true;
                break;
            default:
                // do nothing
                break;
        }
    }

    void takeDamage (int damage)
    {
        toastCurrentHealth -= damage;
        healthBar.setHealth(toastCurrentHealth);
    }
}
