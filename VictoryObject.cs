using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VictoryObject: MonoBehaviour
{
    public TMP_Text victoryMessage; // reference to the text UI
    private HitManager hitManager; // reference to the HitManager component

    private void Start()
    {
        //  find the HitManager component in the scene and assign it to hitManager
        hitManager = FindObjectOfType<HitManager>();
    }

    // if the colliderenters a trigger
    private void OnTriggerEnter(Collider other) 
    {
        // if the collider belongs to the player
        if (other.gameObject.tag == "Player")
        {
            // display the victory message
            DisplayVictoryMessage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // if the player has pressed the R key
        if (Input.GetKeyDown(KeyCode.R))
        {
            // reload the current scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
            );
        }
    }

    // function to display the victory message
    void DisplayVictoryMessage()
    {
        victoryMessage.gameObject.SetActive(true); // activate the UI element

        // set the text to display the victory message with the total hit count
        victoryMessage.text = "Good Job! You touched an object " + hitManager.GetTotalHits() + " times! Press R to try again!"; 
    }
}