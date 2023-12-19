using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
     
     //Set a boolean to determine when the games object collides between two walls.
     bool isitColliding;
    void Start()
    {

        //Set boolean to false in the beginning to determine first movement (to the right).
        isitColliding = false;
    }

    //This is where I would like code to be per frame (Happen again and again).
    void Update()
    {
       //If my boolean variable is set to false
       if(isitColliding == false){

        //Then I will move my object 2 units on the Z axis
        transform.position += new Vector3(0,0, 6 *Time.deltaTime);

       }
        //If my boolean variable is set to true
        if(isitColliding == true){

            //Then I will move my object -2 units on the Z axis
            transform.position += new Vector3(0,0, -6*Time.deltaTime); 

        }
    }

    //Creating a Unity method (function) called OnCollisionEnter with a parameter of Collision representing other
    void OnCollisionEnter(Collision other) {
        

        // if the game object has a tag that is "WallNorth and if my boolean variable is set to false
        if(other.gameObject.tag == "WallNorth" && isitColliding == false){

            //change the boolean variable to true
                isitColliding = true;

                //make the game object not move at all to stop the game object in its path.
              transform.position += new Vector3(0,0, 0);  
           

        }

         // if the game object has a tag that is "WallSouth and if my boolean variable is set to true
        
        if(other.gameObject.tag == "WallSouth" && isitColliding == true){
                
                //change the boolean variable to false
                isitColliding = false;

              //make the game object not move at all to stop the game object in its path.   
              transform.position += new Vector3(0,0, 0);  
           

        }
    }

}

