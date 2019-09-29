using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        //We gonna ask wich key is pressed
        if (Input.GetKey(KeyCode.Space)) // Can thrust while rotating
        {
            print("Thrusting");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("Rotating Left");
            
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("Rotating Right");
        }
        
       
    }
}
