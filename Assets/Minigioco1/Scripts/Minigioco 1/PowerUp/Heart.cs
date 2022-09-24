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
            effect(30);
        }
    }
    void effect(int value)
    {
        health = PlayerHealt.instance.getCurrentHealt();
        health += value;
        disappearEffect();
        disactivePowerUp();
        print(health);
        PlayerHealt.instance.setHealth(health);
        healthBar.SetHealth(health);
        StartCoroutine(PickUp());
    }
    public IEnumerator PickUp()
    { 
        yield return new WaitForSeconds(1);
        Destroy(gameObject); 
    }

    public void disappearEffect()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }    
}

