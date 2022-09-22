using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject weaponsmanager;
    public GameObject newGun;
    public GameObject currentGun;
    public GameObject PowerUpitem;
    public Vector3 sizeChange;
    private float duration = 10f;

    private int effect_control = 0; 
    void Start()
    {
        weaponsmanager = GameObject.FindGameObjectWithTag("WeaponsManager");
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            StartCoroutine(PickUp());
        }

    }

    IEnumerator PickUp()
    { 
        effect_control++; 

         // Spawn a cool effect
        if(effect_control == 1)
            Instantiate(pickupEffect, transform.position, transform.rotation);
                
        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(1);

        // Remove power up from the sceen
        // Problema quando si disarriva rispetto alla corutine
        PowerUpitem = GameObject.FindGameObjectWithTag("PowerUp") ; 
        PowerUpitem.SetActive(false);

        print("inizio effetto");
        // Wait x amount of seconds
        yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(0);

        print("fine effetto");
        effect_control = 0; 
        Destroy(gameObject); 
    }
    
}

