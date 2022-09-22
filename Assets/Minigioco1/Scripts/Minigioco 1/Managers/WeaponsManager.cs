using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsManager : MonoBehaviour
{
    public GameObject[] weapons; 
    public int nrWeapons;
     public int currentWeapon = 0;     
     
     void Start() {
         
         nrWeapons = weapons.Length;
         
         SwitchWeapon(currentWeapon); 
     
     }    
     
    public void SwitchWeapon(int index) {
 
         for (int i=0; i < nrWeapons; i++)    {
             if (i == index) {
                 weapons[i].gameObject.SetActive(true);
             } else { 
                 weapons[i].gameObject.SetActive(false);
             }
         }
     }
}
