using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject newGun;
    public GameObject[] currentGun;
    void start()
    {
        currentGun = GameObject.FindGameObjectsWithTag("Gun");
        // currentGun.SetActive(true);
        newGun.SetActive(false); 
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PickUp();
        }

    }

    void PickUp()
    {
        
        // Spawn a cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        
        // Apply effect to the player 
        // currentGun.SetActive(false);
        newGun.SetActive(true); 
         
        // Remove power up from the sceen
        Destroy(gameObject); 
    }
}
