using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = GameData.speed;
    public float gravity = GameData.gravity;
    public float jumpHeight = GameData.jumpHeight;

    public Transform groundCheck;
    public float groundDistance = GameData.groundDistance; 
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded; 


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        
        if(isGrounded && velocity.y <0 )
        {
            velocity.y = -2f; 
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        /*  Non utilizziamo questa tecnica perche sono cordinate globali e quindi
            non si muoverebbe nella direzione in cui stiamo puntando new Vector3 (x, 0f, z);
            direzione vista dal player per la x + l'altra * z */
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        

        if(Input.GetButtonDown("Jump") && isGrounded )
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            // Debug.Log(velocity.y);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}

//https://www.youtube.com/watch?v=_QajrabyTJc&list=PLPV2KyIb3jR6Wxj8HaJ_pZhBtaamtXL7J&index=1&ab_channel=Brackeys