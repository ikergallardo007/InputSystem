using UnityEngine;

public class InputManager : MonoBehaviour
{

    // Attributes
    public Transform cubeTransform;
    public Transform cameraTransform;
    public float speed = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxis("Horizontal");
        Debug.DrawRay(cubeTransform.position, cubeTransform.right * Input.GetAxis("Horizontal"), Color.red);
        Debug.DrawRay(cubeTransform.position, cubeTransform.forward * Input.GetAxis("Vertical"), Color.blue);

        // Player movement.
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W) || Input.GetKeyUp(KeyCode.W))
        {
            cubeTransform.Translate(cubeTransform.forward * Time.deltaTime * speed);
        }
        
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S) || Input.GetKeyUp(KeyCode.S))
        {
            cubeTransform.Translate(cubeTransform.forward * Time.deltaTime * speed * (-1));
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D) || Input.GetKeyUp(KeyCode.D))
        {
            cubeTransform.Translate(cubeTransform.right * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A) || Input.GetKeyUp(KeyCode.A))
        {
            cubeTransform.Translate(cubeTransform.right * Time.deltaTime * speed * (-1));
        }

        // Locate the camera on top of the cube position.
        cameraTransform.position = new Vector3(cubeTransform.position.x, cameraTransform.position.y, cubeTransform.position.z);
    }
}
