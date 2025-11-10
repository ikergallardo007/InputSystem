using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Key Down & Up: Enter
        if (Input.GetKeyDown(KeyCode.Return))
            print("Se ha pulsado enter.");
        if (Input.GetKey(KeyCode.Return))
            print("Se está pulsando enter.");
        if (Input.GetKeyUp(KeyCode.Return))
            print("Se ha soltado enter.");
    }
}
