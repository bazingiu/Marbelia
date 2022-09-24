using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    protected GameObject pickupEffect;
    protected GameObject PowerUpitem;
    // public Vector3 sizeChange;
    protected float duration = GameData.duration;
    protected int effect_control = 0; 
    protected delegate void MultiDelegate();
    protected MultiDelegate visiveEffect;
  
    public virtual void Start()
    {
        visiveEffect += disappearEffect;
        visiveEffect += disactivePowerUp;
    }
    public void disactivePowerUp ()
    {
        PowerUpitem = GameObject.FindGameObjectWithTag("PowerUp") ; 
        PowerUpitem.SetActive(false);
    }

    public void disappearEffect()
    {
        effect_control++; 
        if(effect_control == 1)
            Instantiate(pickupEffect, transform.position, transform.rotation);
    }
    
}

