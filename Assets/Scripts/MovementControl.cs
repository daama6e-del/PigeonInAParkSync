using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float moveSpeed = 1.0f;
    public float jumpForce = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Pidgeon")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); //Interface input going into system
        Vector3 moveDirection = Vector3.forward * moveSpeed * horizontalInput * Time.deltaTime; //vector mean- representing the world position of out GO 
        rigidbody.AddForce(moveDirection, ForceMode.Acceleration);

        if (Input.GetKeyDown(KeyCode.Space)) //Pressed the key to jump
        {
            Vector3 jumpDirection = Vector3.up * jumpForce;
            rigidbody.AddForce(jumpDirection, ForceMode.VelocityChange);
        }

        Vector3 velocity = rigidbody.velocity;
        velocity.y = 0.0f; //Constant Value here
        if (velocity.magnitude > 0.0f)
        {
            transform.rotation = Quaternion.LookRotation(velocity);
        }

    }
}
