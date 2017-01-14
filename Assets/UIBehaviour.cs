using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UIBehaviour : MonoBehaviour {
    public float fullFule = 100;
    public float currentFule;
    public Slider fuelSlider;
    public Rigidbody player; //tank
    

    SimpleCarController tank;
    SimpeFireScript fire;
    
    
    void Start () {
        
       
        currentFule = fullFule;
    }
	
	
	void Update () {
        
    }

    public void ConsumeFuel(float ammount)
    {

        currentFule = currentFule - ammount;

        fuelSlider.value = currentFule;
    }

    
}
