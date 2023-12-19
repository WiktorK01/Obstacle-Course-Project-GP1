using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenButton : MonoBehaviour
{
    public void OnClickButton() //when the UI button is clicked
    {

        SceneManager.LoadScene("SampleScene"); //load scene titled "SampleScene

    }
}