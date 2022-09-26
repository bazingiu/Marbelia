using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGun : PowerUp
{
    public GameObject weaponsmanager;
    public Vector3 sizeChange;
    public override void Start()
    {
        print("Spowned mp5");
        weaponsmanager = GameObject.FindGameObjectWithTag("WeaponsManager");
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
           effect(); 
        }
    }

    public void effect()
    {
        StartCoroutine(PickUp());
    }

    public IEnumerator PickUp()
    { 
        // Spawn a cool effect and remove power up from the sceen
        disappearEffect();
        disactivePowerUp();

        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(1);

        // Wait x amount of seconds
        yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(0);

        effect_control = 0; 
        Destroy(gameObject); 
    }

    public void disappearEffect()
    {
        effect_control++; 
        if(effect_control == 1)
            Instantiate(pickupEffect, transform.position, transform.rotation);
    }
}

