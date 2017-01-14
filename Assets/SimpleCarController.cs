using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}

public class SimpleCarController : MonoBehaviour
{
    public List<AxleInfo> axleInfos; 
    public float maxMotorTorque;
    public float maxSteeringAngle;  // not used
    public Rigidbody tank;
    public float moveSensor;        //speed at witch the thank is considered to move forward and not stationary
    public float magnitude;
    GameObject UI;



    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }

        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }
    void start()
    {
	
       
    }
    public void FixedUpdate()
    {
        GameObject UI = GameObject.Find("Canvas");
        //UI.GetComponent<UIBehaviour>().ConsumeFuel(tank.velocity.magnitude);

        magnitude = tank.velocity.magnitude;
        float motor = maxMotorTorque;
        bool power = true;
        
        

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.motor)
            {
                if (tank.velocity.magnitude > moveSensor)
                {
                    if (Input.GetKey("right"))
                    {
                        axleInfo.leftWheel.motorTorque = motor;
                        axleInfo.rightWheel.motorTorque = 0f;
                        power = false;
                        
                    }
                    else if (Input.GetKey("left"))
                    {
                        axleInfo.leftWheel.motorTorque = 0f;
                        axleInfo.rightWheel.motorTorque = motor;
                        power = false;
                        
                    }

                    else if (Input.GetKey("down"))
                    {
                        axleInfo.leftWheel.motorTorque = motor;
                        axleInfo.rightWheel.motorTorque = motor;
                        power = false;
                    }
                    else if (Input.GetKey("up"))
                    {
                        axleInfo.leftWheel.motorTorque = -motor;
                        axleInfo.rightWheel.motorTorque = -motor;
                        power = false;
                    }
                    if (power == true)
                    {
                        axleInfo.leftWheel.motorTorque = 0f;
                        axleInfo.rightWheel.motorTorque = 0f;
                    }
                    UI.GetComponent<UIBehaviour>().ConsumeFuel(tank.velocity.magnitude * 0.01f);

                }
                else
                {
                    if (Input.GetKey("right"))
                    {
                        axleInfo.leftWheel.motorTorque = motor;
                        axleInfo.rightWheel.motorTorque = -motor;
                        power = false;
                    }
                    else if (Input.GetKey("left"))
                    {
                        axleInfo.leftWheel.motorTorque = -motor;
                        axleInfo.rightWheel.motorTorque = motor;
                        power = false;
                    }

                    else if (Input.GetKey("down"))
                    {
                        axleInfo.leftWheel.motorTorque = motor;
                        axleInfo.rightWheel.motorTorque = motor;
                        power = false;
                    }
                    else if (Input.GetKey("up"))
                    {
                        axleInfo.leftWheel.motorTorque = -motor;
                        axleInfo.rightWheel.motorTorque = -motor;
                        power = false;
                    }
                    if (power == true)
                    {
                        axleInfo.leftWheel.motorTorque = 0f;
                        axleInfo.rightWheel.motorTorque = 0f;
                    }
                    
                }
                
            }
            ApplyLocalPositionToVisuals(axleInfo.leftWheel);
            ApplyLocalPositionToVisuals(axleInfo.rightWheel);
        }
    }
}
