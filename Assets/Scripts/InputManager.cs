using UnityEngine;

public class InputManager : MonoBehaviour
{

    // Attributes
    public Transform cubeTransform;
    public Transform cameraTransform;
    public float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        // Player movement.
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W) || Input.GetKeyUp(KeyCode.W))
        {
            cubeTransform.Translate(speed * Time.deltaTime * cubeTransform.forward, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S) || Input.GetKeyUp(KeyCode.S))
        {
            cubeTransform.Translate((-1) * speed * Time.deltaTime * cubeTransform.forward, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            cubeTransform.Translate(speed * Time.deltaTime * cubeTransform.right, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A) || Input.GetKeyUp(KeyCode.A))
        {
            cubeTransform.Translate((-1) * speed * Time.deltaTime * cubeTransform.right, Space.World);
        }

        // Locate the camera on top of the cube position.
        cameraTransform.position = new Vector3(cubeTransform.position.x, cameraTransform.position.y, cubeTransform.position.z);

        //DrawRays to se the movement.
        Debug.DrawRay(cubeTransform.position, cubeTransform.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, cubeTransform.forward * Input.GetAxis("Vertical"), Color.blue);
        Debug.DrawRay(cubeTransform.position, cubeTransform.forward, Color.green);
    }
}
