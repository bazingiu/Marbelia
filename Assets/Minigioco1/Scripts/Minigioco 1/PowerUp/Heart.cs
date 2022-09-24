using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : PowerUp
{
    public HealthBar healthBar;
    private int health;

    public override void Start()
    {
        visiveEffect += disappearEffect;
        visiveEffect += disactivePowerUp;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            improveHealt();
        }
    }
    void improveHealt()
    {
        health = PlayerHealt.instance.getCurrentHealt();
        health += 30;
        print(health);
        // HealthBar.SetMaxHealth(health);
        PlayerHealt.instance.setHealth(health);
        // healthBar.SetHealth(health);
        Destroy(gameObject); 
    }
}

