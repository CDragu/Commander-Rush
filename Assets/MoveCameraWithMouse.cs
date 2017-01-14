using UnityEngine;
using System.Collections;

public class MoveCameraWithMouse : MonoBehaviour {

    public float mouseSensitivity = 1f;
    private Vector3 lastPosition;
    // Use this for initialization
    void Start() { }
        
    
	
	
	
	// Update is called once per frame
	void Update () {
        Vector3 delta;
        if (Input.GetMouseButtonDown(0))
        {
            lastPosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            delta = Input.mousePosition - lastPosition;
            transform.Translate(delta.x * mouseSensitivity, delta.y * mouseSensitivity, 0);
            lastPosition = Input.mousePosition;
        }

    }
}
