﻿using UnityEngine;
using System.Collections;

public class WellBehavior : MonoBehaviour {
    public int speed;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.left * speed);
        }
    }
}
