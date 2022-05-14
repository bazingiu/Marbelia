﻿using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f; 
    
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    void Start()
    {
        //muzzleFlash = GetComponent<ParticleSystem>();
        //muzzleFlash.enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Quando si preme il tasto destro per sparare
        if(Input.GetButtonDown("Fire2"))
        {
            shoot();
        }
    }

    //sparo con raycast, si fa il controllo se si prende qualcosa o meno
    void shoot()
    {   
        //if( muzzleFlash.enableEmission = false) muzzleFlash.enableEmission = true;;
        muzzleFlash.Play();
        
        RaycastHit hit; 
        //controlliamo se abbiamo preso qualcosa sparando
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
        }

    }
}
