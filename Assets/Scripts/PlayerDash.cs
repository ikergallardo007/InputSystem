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
            if (tapW)
            {
                if (DateTime.Now.Subtract(wTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.forward);
                    tapW = false;
                }
                else
                {
                    wTime = DateTime.Now;
                }
            } 
            else
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

            if (tapS)
            {
                if (DateTime.Now.Subtract(sTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.forward * (-1));
                    tapS = false;
                }
                else
                {
                    sTime = DateTime.Now;
                }
            }
            else
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
            if (tapD)
            {
                if (DateTime.Now.Subtract(dTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.right);
                    tapD = false;
                }
                else
                {
                    dTime = DateTime.Now;
                }
            }
            else
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
            if (tapA)
            {
                if (DateTime.Now.Subtract(aTime).TotalMilliseconds < doubleTapTime)
                {
                    cubeTransform.Translate(cubeTransform.right * (-1));
                    tapA = false;
                }
                else
                {
                    aTime = DateTime.Now;
                }
            }
            else
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
