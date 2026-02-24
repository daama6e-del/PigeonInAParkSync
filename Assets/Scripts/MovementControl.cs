using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{

public float moveSpeed = 1.0f;

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
        float horizontalInput = Input.GetAxis("Horixontal"); //Interface input going into system
        transform.position += Vector3.forward * moveSpeed * horizontalInput * Time.deltaTime; //vector mean- representing the world position of out GO 

    }
}
