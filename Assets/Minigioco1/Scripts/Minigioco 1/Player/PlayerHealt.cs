using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealt : MonoBehaviour
{
    public static PlayerHealt instance;
    void Awake()
    {
        instance = this;
    }
    public int maxHealth = GameData.maxHealth;
    public int currentHealth;
    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
        {
            Time.timeScale = 0;
            GameOverScript.instance.Setup();
        }
    }

    public int getCurrentHealt()
    {
        return currentHealth;
    }

    public void setHealth(int healt)
    {
        currentHealth = healt; 
    }
}
