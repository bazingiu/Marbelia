
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
            Die();
        }
    }

    private void Die()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsDeath", true);
        gameObject.SetActive(false);
        PointManager.instance.AddPoints(point);
    }
}
