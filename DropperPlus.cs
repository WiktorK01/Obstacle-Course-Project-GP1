using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropperPlus : MonoBehaviour
{
    [SerializeField] float waitingTime = 2.5f; // waiting time in seconds before instantiating/destroying an object
    [SerializeField] GameObject dropObject; // reference for the object that will be dropped

    bool hasDropped = false; //check if the object has been dropped

    void Update()
    {
        // if the object has not been dropped and the time is greater than the waiting time
        if (!hasDropped && Time.time > waitingTime)
        {
            // instantiate the object at the current transform position with no rotation
            GameObject droppedInstance = Instantiate(dropObject, transform.position, Quaternion.identity);
            // destroy the dropped instance after the same duration as waitingTime
            Destroy(droppedInstance, waitingTime); 
            // set hasDropped to true sinec it has now been dropped
            hasDropped = true; 
        }
    }
}