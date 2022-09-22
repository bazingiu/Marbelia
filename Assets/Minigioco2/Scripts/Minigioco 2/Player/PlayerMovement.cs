using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float speed;
    
    void Start()
    {
        
    }
    void Update()
    {
        var movement = Input.GetAxis("Vertical"); 
        transform.position += new Vector3(0, movement, 0) * Time.deltaTime * speed;
    }
}
