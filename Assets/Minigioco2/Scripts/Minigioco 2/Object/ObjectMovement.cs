using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Minigioco2
{
    public class ObjectMovement : MonoBehaviour
    {
        [SerializeField] float speed;
        void Update()
        {
            transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime * speed;
        }
    }
}
