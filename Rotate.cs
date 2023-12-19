using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
[SerializeField]float rotationSpeed = 100f; // speed at which the object will rotate

    void Update()
    {
        // Rotate around the Y-axis, use Time.deltaTime to ensure smooth movement
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
