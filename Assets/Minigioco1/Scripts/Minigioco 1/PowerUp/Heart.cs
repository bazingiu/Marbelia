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
        print("Spowned heart");
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            gameObject.SetActive(false);
            effect(50);
        }
    }
    void effect(int value)
    {
        health = PlayerHealt.instance.getCurrentHealt();
        health += value;
        if(health > 100)
        {
            health = 100; 
        } 

        disappearEffect();

        PlayerHealt.instance.setHealth(health);
        healthBar.SetHealth(health);

        Destroy(gameObject); 
    }

    public void disappearEffect()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }    
}

