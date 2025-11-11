using System;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    // Public Properties
    public Transform cubeTransform;
    public float doubleTapTime = 300f;

    // Private Attributes
    private DateTime wTime;
    private DateTime sTime;
    private DateTime dTime;
    private DateTime aTime;
    private bool dobleTapW = true;
    private bool dobleTapS = true;
    private bool dobleTapD = true;
    private bool dobleTapA = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            if (dobleTapW)
            {
                wTime = DateTime.Now;
                dobleTapW = false;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (wTime.Second * 1000 + wTime.Millisecond)) < doubleTapTime)
            {
                print("Se ha pulsado W dos veces seguidas");
                cubeTransform.Translate(Vector3.forward);
                dobleTapW = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            if (dobleTapS)
            {
                sTime = DateTime.Now;
                dobleTapS = false;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (sTime.Second * 1000 + sTime.Millisecond)) < doubleTapTime)
            {
                print("Se ha pulsado S dos veces seguidas");
                cubeTransform.Translate(Vector3.forward * (-1));
                dobleTapS = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            if (dobleTapD)
            {
                dTime = DateTime.Now;
                dobleTapD = false;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (dTime.Second * 1000 + dTime.Millisecond)) < doubleTapTime)
            {
                print("Se ha pulsado D dos veces seguidas");
                cubeTransform.Translate(Vector3.right);
                dobleTapD = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            if (dobleTapA)
            {
                aTime = DateTime.Now;
                dobleTapA = false;
            }
            else if (((DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - (aTime.Second * 1000 + aTime.Millisecond)) < doubleTapTime)
            {
                print("Se ha pulsado A dos veces seguidas");
                cubeTransform.Translate(Vector3.right * (-1));
                dobleTapA = true;
            }
        }
    }
}
