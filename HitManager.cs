using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitManager : MonoBehaviour
{
    int totalHits = 0; // to keep track of the total number of hits

    //increment the hit count
    public void IncrementHitCount()
    {
        totalHits++;
    }

    //get the total number of hits
    public int GetTotalHits()
    {
        return totalHits; 
    }
}
