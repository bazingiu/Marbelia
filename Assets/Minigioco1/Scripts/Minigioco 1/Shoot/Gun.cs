﻿// For the gun shoot
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = GameData.damage;
    public float range = GameData.range; 
    public bool shootOn;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    
    public void disableShoot()
    {
        shootOn = false; 
    }

    public void enableShoot()
    {
        shootOn = true; 
    }
    void Update()
    {
        if(shootOn == true)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                shoot();
            }
        }
    }
    
    //shoot with raycast, look if the bull arrived somewere 
    void shoot()
    {   
        FindObjectOfType <AudioManager>().Play("shoot");
        muzzleFlash.Play();
        
        RaycastHit hit; 

        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            // Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}