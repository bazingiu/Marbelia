using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float rotationSpeed;
    [SerializeField] public int points;
    [SerializeField] protected float maxHealth;
    float health;

    // OnEnable set maxHealth
    private void OnEnable()
    {
        health = maxHealth;
    }

    protected virtual void Init()
    {
        Debug.Log("Init di enemy");
    }

    protected virtual void Start()
    {
        Init();
    }

    // Update is called once per frame
    public void Hit(float damage)
    {
        Debug.Log(maxHealth);
        health -= damage;
        if (health <= 0)
        {
            PointManager.instance.AddPoints(points);
            //GameManager.Instance
            gameObject.SetActive(false);
        }
    }
    public void Spawn(Transform spawnPoint)
    {
        transform.position = spawnPoint.position;
    }
}
