using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{

    public class Player : MonoBehaviour
    {

        [SerializeField] protected float maxHealth;
        [SerializeField] protected float speed;

        public bool invicible = false;
        public float health;
        [SerializeField] public int points = 0;

        public GameManager game;

        public HealthBar healthBar;

        void Start()
        {
            Init();
        }

        public float getHealth()
        {
            return health;
        }

        private void Init()
        {
            health = maxHealth;
            healthBar.SetMaxHealth(maxHealth);
        }

        void Update()
        {
            
        }

        public void Hit(float damage)
        {
            if (invicible == false)
            {
                health -= damage;
                healthBar.SetHealth(health);
            }
            if (health <= 0)
            {
                Time.timeScale = 0;
                Kill();
            }
        }

        public void Kill()
        {
            gameObject.SetActive(false);
            game.GameOver();
        }

        public void addPoints(int newPoints)
        {
            points += newPoints;
        }
    }
}
