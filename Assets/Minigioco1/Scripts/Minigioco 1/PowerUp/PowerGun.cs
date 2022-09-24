using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerGun : PowerUp
{
    public GameObject weaponsmanager;
    public GameObject newGun;
    public GameObject currentGun;
    public Vector3 sizeChange;
    public override void Start()
    {
        weaponsmanager = GameObject.FindGameObjectWithTag("WeaponsManager");
        visiveEffect += disappearEffect;
        visiveEffect += disactivePowerUp;
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {   
            StartCoroutine(PickUp());
        }
    }

    public IEnumerator PickUp()
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
}

