using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreFeedback : MonoBehaviour
{

    int hits = 0; // keeps track of the how many times player touches objects

    public HitManager hitManager; // reference to the HitManager component
    public TextMeshProUGUI scoreUI; // reference to the score UI

    void Update() // called every frame
    {
        // update the text of the score UI with the total number of hits
        scoreUI.text = "Hit Count: " + hitManager.GetTotalHits().ToString();
    }
}

