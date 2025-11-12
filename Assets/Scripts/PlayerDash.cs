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
    private bool tapW = false; // "W" key pressed.
    private bool tapS = false; // "S" key pressed.
    private bool tapD = false; // "D" key pressed.
    private bool tapA = false; // "A" key pressed.

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
            // Look if "W" has been tapped before.
            if (tapW)
            {
                // Look if the time between two taps is smaller than the defined time, in milliseconds.
                if (DateTime.Now.Subtract(wTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.forward); // Translate the cube in the direction.
                    tapW = false; // Restart as "W" has not been pressed before.
                }
                else // If the player last more time for the second press restart the time.
                {
                    wTime = DateTime.Now;
                }
            } 
            else // If it is the first tap, collect the tap of "W", remove other keys and save the time.
            {
                wTime = DateTime.Now;
                tapW = true;
                tapS = false;
                tapD = false;
                tapA = false;
            }
        }

        // "S" key
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Look if "S" has been tapped before.
            if (tapS)
            {
                // Look if the time between two taps is smaller than the defined time, in milliseconds.
                if (DateTime.Now.Subtract(sTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.forward * (-1)); // Translate the cube in the direction.
                    tapS = false; // Restart as "S" has not been pressed before.
                }
                else // If the player last more time for the second press restart the time.
                {
                    sTime = DateTime.Now;
                }
            }
            else // If it is the first tap, collect the tap of "W", remove other keys and save the time.
            {
                sTime = DateTime.Now;
                tapS = true;
                tapW = false;
                tapD = false;
                tapA = false;
            }
        }

        // "D" key
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Look if "D" has been tapped before.
            if (tapD)
            {
                // Look if the time between two taps is smaller than the defined time, in milliseconds.
                if (DateTime.Now.Subtract(dTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.right); // Translate the cube in the direction.
                    tapD = false; // Restart as "D" has not been pressed before.
                }
                else // If the player last more time for the second press restart the time.
                {
                    dTime = DateTime.Now;
                }
            }
            else // If it is the first tap, collect the tap of "W", remove other keys and save the time.
            {
                dTime = DateTime.Now;
                tapD = true;
                tapS = false;
                tapW = false;
                tapA = false;
            }
        }

        // "A" key
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Look if "A" has been tapped before.
            if (tapA)
            {
                // Look if the time between two taps is smaller than the defined time, in milliseconds.
                if (DateTime.Now.Subtract(aTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.right * (-1)); // Translate the cube in the direction.
                    tapA = false; // Restart as "A" has not been pressed before.
                }
                else // If the player last more time for the second press restart the time.
                {
                    aTime = DateTime.Now;
                }
            }
            else // If it is the first tap, collect the tap of "W", remove other keys and save the time.
            {
                aTime = DateTime.Now;
                tapA = true;
                tapS = false;
                tapD = false;
                tapW = false;
            }
        }
    }
}
