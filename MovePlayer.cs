using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float playerSpeed = 50f; // speed of player
    Rigidbody rb; // reference to the Rigidbody of the object

    // on the first frame
    void Start()
    {   
        rb = GetComponent<Rigidbody>(); // get the Rigidbody component
        PrintInstructions(); //print game instructions
    }

    //every frame
    void Update()
    {
        PlayerMovement(); // call the method to handle player movement
    }

    // funcyion to print the game instructions to the console
    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game.");
        Debug.Log("Move your player with WASD or Arrow Keys");
        Debug.Log("Don't hit the wall or the objects!");
    }

    // function to handle the player's movement
    void PlayerMovement()
    {
        // calculate movement based on player input and speed
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;

        Vector3 movement = new Vector3(xValue, 0f, zValue) * Time.fixedDeltaTime; // create a movement vector and apply it to the Rigidbody
        rb.MovePosition(rb.position + movement); // move the player's Rigidbody to the new position
    }
}

