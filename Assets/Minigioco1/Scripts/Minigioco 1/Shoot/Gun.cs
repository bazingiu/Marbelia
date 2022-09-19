// For the gun shoot
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f; 
    
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
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
