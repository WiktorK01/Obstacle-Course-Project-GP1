using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool hitOnce = false; //check if the object has been hit before

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player") // if the collided object has the tag "Player"
        {
            if (!hitOnce) // if the object has not been hit before
            {
                GetComponent<MeshRenderer>().material.color = Color.yellow; // change color to yellow
                hitOnce = true; // set flag to show the object has been hit
            }
            else // if the object has been hit
            {
                GetComponent<MeshRenderer>().material.color = Color.red; // change color to red
                hitOnce = false; // reset the flag
            }
            HitManager hitManager = FindObjectOfType<HitManager>();// find the HitManager object in the scene
            hitManager.IncrementHitCount(); // increment the hit count
        }
    }
}