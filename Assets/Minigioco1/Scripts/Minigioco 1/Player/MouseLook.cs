// Per ruotare il corpo del personaggio
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensibility = GameData.mouseSensibility; 

    public Transform playerBody;

    float xRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime; //per distaccarlo rispetto al framerate
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;
    
        xRotation -= mouseY; //con il + sarebbe flippata
        // per far in modo che la rotazione non sia eccessiva 
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); 
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
