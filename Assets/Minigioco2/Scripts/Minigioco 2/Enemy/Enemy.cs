using Minigioco2;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{
    public class Enemy : MonoBehaviour
    {

        [SerializeField] protected float speed;
        [SerializeField] protected float strength;

        protected virtual void Init()
        {
        }

        void Start()
        {
            Init();
        }
        void Update()
        {

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 8)
            {
                collision.gameObject.GetComponent<Player>().Hit(strength);
                gameObject.SetActive(false);
            }
        }
    }

}
