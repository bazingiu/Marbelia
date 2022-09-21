using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.position += new Vector3(-speed, 0, 0) * Time.deltaTime * speed;
    }
}
