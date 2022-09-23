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
    private float duration = GameData.duration;
    private int effect_control = 0; 
    delegate void MultiDelegate();
    MultiDelegate visiveEffect;
    void Start()
    {
        weaponsmanager = GameObject.FindGameObjectWithTag("WeaponsManager");
        visiveEffect += disappearEffect;
        visiveEffect += disactivePowerUp;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            StartCoroutine(PickUp());
        }

    }

    //   
    IEnumerator PickUp()
    { 
        // Spawn a cool effect and remove power up from the sceen
        visiveEffect();

        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(1);

        print("inizio effetto");
        // Wait x amount of seconds
        yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        weaponsmanager.GetComponent<WeaponsManager>().SwitchWeapon(0);

        print("fine effetto");
        effect_control = 0; 
        Destroy(gameObject); 
    }

    void disactivePowerUp ()
    {
        PowerUpitem = GameObject.FindGameObjectWithTag("PowerUp") ; 
        PowerUpitem.SetActive(false);
    }

    void disappearEffect()
    {
        effect_control++; 
        if(effect_control == 1)
            Instantiate(pickupEffect, transform.position, transform.rotation);
    }
    
}

