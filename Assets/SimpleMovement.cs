using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {

    public float Speed;
    public float RotationSpeed;
	// Use this for initialization
	void Start () {
        
	
	}
	
	// Update is called once per frame
	void Update () {

       Speed  = 5.0f;
       RotationSpeed  = 50.0f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * Speed, Space.Self);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -Speed, Space.Self);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -RotationSpeed, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed, Space.Self);
        }

    }
}
