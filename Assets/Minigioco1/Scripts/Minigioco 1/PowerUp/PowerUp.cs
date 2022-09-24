using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    protected GameObject PowerUpitem;
    protected float duration = GameData.duration;
    protected int effect_control = 0; 
    
    public void effect()
    {
    }

    public virtual void Start()
    {
    }
    public void disactivePowerUp ()
    {
        PowerUpitem = GameObject.FindGameObjectWithTag("PowerUp") ; 
        PowerUpitem.SetActive(false);
    }

    public virtual void disappearEffect()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);
    }    
}

