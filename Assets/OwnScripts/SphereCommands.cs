﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCommands : MonoBehaviour {

    public GameObject PilatusPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        
        PilatusPanel.SetActive(!PilatusPanel.activeSelf);

        // If the sphere has no Rigidbody component, add one to enable physics.
        /*if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }*/
    }
}
