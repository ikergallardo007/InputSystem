using UnityEngine;

public class PlayerLookAndMove : MonoBehaviour
{
    // Public Properties
    public Transform cubeTransform;

    // Update is called once per frame
    void Update()
    {
        // The cube looks at the mouse position.
        cubeTransform.LookAt(new Vector3((Input.mousePosition.x - (Screen.width / 2)),cubeTransform.position.y, (Input.mousePosition.y - (Screen.height / 2))));
    }
}
