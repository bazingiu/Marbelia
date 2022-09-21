
//To make damage at the enemy
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f; 
    public int point  = 1;
    Animator animator;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            die();
        }
    }

    private void die()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsDeath", true);
        FindObjectOfType <AudioManager>().Play("EnemyKill");
        Destroy(gameObject);
        PointManager.instance.AddPoints(point);
    }
}
