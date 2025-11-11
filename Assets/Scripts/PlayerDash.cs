using System;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    // Public Properties
    public Transform cubeTransform; // Player
    public float doubleTapTime = 300f; // Time in milliseconds to consider double tap.

    // Private Attributes
    private DateTime wTime; // Time that "W" was pressed.
    private DateTime sTime; // Time that "S" was pressed.
    private DateTime dTime; // Time that "D" was pressed.
    private DateTime aTime; // Time that "A" was pressed.
    private bool tapW = true; // Waiting for first "W" tap.
    private bool tapS = true; // Waiting for first "S" tap.
    private bool tapD = true; // Waiting for first "D" tap.
    private bool tapA = true; // Waiting for first "A" tap.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // "W" key
        if (Input.GetKeyDown(KeyCode.W))
        {

            if (tapW)
            {
                // "W" is pressed, so other keys has to be initialised, in case some of them was pressed before.
                wTime = DateTime.Now; // Obtain the time that "W" is tapped.
                tapW = false;
                tapS = true; 
                tapD = true;
                tapA = true;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (wTime.Second * 1000 + wTime.Millisecond)) < doubleTapTime) // Calculation of the time in millisecond between two taps.
            {
                print("Se ha pulsado W dos veces seguidas");
                cubeTransform.Translate(Vector3.forward); // Translation of the Player in the appropriate direction
                tapW = true;
            }
        }

        // "S" key
        if (Input.GetKeyDown(KeyCode.S))
        {

            if (tapS)
            {
                // "S" is pressed, so other keys has to be initialised, in case some of them was pressed before.
                sTime = DateTime.Now; // Obtain the time that "S" is tapped.
                tapS = false;
                tapW = true;
                tapD = true;
                tapA = true;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (sTime.Second * 1000 + sTime.Millisecond)) < doubleTapTime) // Calculation of the time in millisecond between two taps.
            {
                print("Se ha pulsado S dos veces seguidas");
                cubeTransform.Translate(Vector3.forward * (-1)); // Translation of the Player in the appropriate direction
                tapS = true;
            }
        }

        // "D" key
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (tapD)
            {
                // "D" is pressed, so other keys has to be initialised, in case some of them was pressed before.
                dTime = DateTime.Now; // Obtain the time that "D" is tapped.
                tapD = false;
                tapW = true;
                tapS = true;
                tapA = true;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (dTime.Second * 1000 + dTime.Millisecond)) < doubleTapTime) // Calculation of the time in millisecond between two taps.
            {
                print("Se ha pulsado D dos veces seguidas");
                cubeTransform.Translate(Vector3.right); // Translation of the Player in the appropriate direction
                tapD = true;
            }
        }

        // "A" key
        if (Input.GetKeyDown(KeyCode.A))
        {

            if (tapA)
            {
                // "A" is pressed, so other keys has to be initialised, in case some of them was pressed before.
                aTime = DateTime.Now; // Obtain the time that "A" is tapped.
                tapA = false;
                tapW = true;
                tapS = true;
                tapD = true;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (aTime.Second * 1000 + aTime.Millisecond)) < doubleTapTime) // Calculation of the time in millisecond between two taps.
            {
                print("Se ha pulsado A dos veces seguidas");
                cubeTransform.Translate(Vector3.right * (-1)); // Translation of the Player in the appropriate direction
                tapA = true;
            }
        }
    }
}
