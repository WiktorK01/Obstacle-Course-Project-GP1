using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    bool collideWithMe; // flag to track collision state
    
    //movement amounts for all axis
    float positionX;
    float positionY;
    float positionZ;

    //reset value for all axis
    float resetX;
    float resetY;
    float resetZ;

    //speed of the enemy
    float enemySpeedOne;
    
    //on first frame, initialize all values  
    void Start()
    {
        collideWithMe = false;
        positionX = 2f;
        positionY = 0;
        positionZ = 0;

        resetX = 0;
        resetY = 0;
        resetZ = 0;

        enemySpeedOne = 5f;

    }

    // Update is called once per frame
    void Update()
    {
        if(collideWithMe == false){
            // move to the right when not collided
            transform.position += new Vector3(positionX* Time.deltaTime * enemySpeedOne, positionY, positionZ);
        }
        if(collideWithMe == true){
            // move to the left when collided
            transform.position += new Vector3(-positionX * Time.deltaTime * enemySpeedOne, positionY, positionZ);
        }

        }
    

     void OnCollisionEnter(Collision other) 
     {
        // change direction when colliding with the east wall
        if(other.gameObject.tag == "WallEast" && collideWithMe == false)
        {
                collideWithMe = true;
              transform.position += new Vector3(resetX, resetY, resetZ);//reset position

        }
        // change direction when colliding with the west wall
        if(other.gameObject.tag == "WallWest" && collideWithMe == true)
        {
                collideWithMe = false;
              transform.position += new Vector3(resetX, resetY, resetZ); //reset position 

        }

        }

}
