﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweepCommands : MonoBehaviour
{
    public Color altColor = Color.yellow;
    public GameObject Sphere;

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material.color = altColor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        //transform.Translate(Vector3.up * Time.deltaTime, Space.World);

        //Sphere.SetActive(!Sphere.activeSelf);

        //altColor.a = 00;
        GetComponent<Renderer>().material.color = Color.black;

        // If the sphere has no Rigidbody component, add one to enable physics.
        /*if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }*/
    }
}

