
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f; 
    public int point  = 1;

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
        gameObject.SetActive(false);
        PointManager.instance.AddPoints(point);
    }
}
