using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{
    public class Object : MonoBehaviour
    {
        [SerializeField] protected int points;

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

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.layer == 8)
            {
                col.gameObject.GetComponent<Player>().addPoints(points);
                gameObject.SetActive(false);
            }
        }

        /*private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 8){
                collision.gameObject.GetComponent<Player>().addPoints(points);
                gameObject.SetActive(false);
            }
        }*/
    }
}
