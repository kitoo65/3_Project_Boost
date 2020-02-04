using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    Rigidbody rigidBody;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
            {
                rigidBody.AddRelativeForce(Vector3.up);
                print("Thrusting");
                if (!audioSource.isPlaying) //Para que no se superponga 
                {
                    audioSource.Play();

                }
            }
        }
        else
        {
            audioSource.Stop();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
            print("Rotating Left");

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward);
            print("Rotating Right");
        }
    }
}
