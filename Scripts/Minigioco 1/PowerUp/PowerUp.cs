using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public GameObject newGun;
    public GameObject currentGun;
    public GameObject PowerUpitem;
    public Vector3 sizeChange;
    private float duration = 5f;
    public Renderer rend;

    private int effect_control = 0; 
    void Start()
    {
        currentGun = GameObject.Find("Gun");
        newGun = GameObject.Find("mp5");
        rend = newGun.GetComponent<Renderer>();
        print(currentGun);
        print(newGun);
        currentGun.SetActive(true);
        // newGun.SetActive(false); 
        rend.enabled = false;
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
            
        // Apply effect to the player 
        // currentGun.SetActive(false);
        currentGun.SetActive(false);
        // newGun.SetActive(true); 
        rend.enabled = true;
         
        // Remove power up from the sceen
        // Problema quando si disarriva rispetto alla corutine
        PowerUpitem = GameObject.FindGameObjectWithTag("PowerUp") ; 
        PowerUpitem.SetActive(false);
        {


        print("inizio effetto");
        // Wait x amount of seconds
        yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        currentGun.SetActive(true);
        // newGun.SetActive(true); 
        rend.enabled = false;

        print("fine effetto");
        effect_control = 0; 
        Destroy(gameObject); 
    }
    
}

}
