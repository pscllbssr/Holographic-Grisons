﻿using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class GazeGestureManager : MonoBehaviour
{
    public static GazeGestureManager Instance { get; private set; }

    // Represents the hologram that is currently being gazed at.
    public GameObject FocusedObject { get; private set; }
    
    GestureRecognizer recognizer;

    void Start()
    {
       // FocusedObject = null;
    }


    // Use this for initialization
    void Awake()
    {
        Instance = this;
        FocusedObject = null;
        // Set up a GestureRecognizer to detect Select gestures.
        recognizer = new GestureRecognizer();
        recognizer.Tapped += (args) =>
        {
            // Send an OnSelect message to the focused object and its ancestors.
            if (FocusedObject != null)
            {
                FocusedObject.SendMessageUpwards("OnSelect", FocusedObject, SendMessageOptions.DontRequireReceiver);
            }
        };
        recognizer.StartCapturingGestures();
    }

    // Update is called once per frame
    void Update()
    {
        // Figure out which hologram is focused this frame.
        GameObject oldFocusObject = FocusedObject;

        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;
        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            // If the raycast hit a hologram, use that as the focused object.
            FocusedObject = hitInfo.collider.gameObject;
            FocusedObject.SendMessageUpwards("OnFocus", SendMessageOptions.DontRequireReceiver);
            //Debug.Log("If 1");

        }
        else
        {
                           
            FocusedObject = null;
            
        }

        // If the focused object changed this frame,
        // start detecting fresh gestures again.
        if (FocusedObject != oldFocusObject)
        {
            if (oldFocusObject != null)
            {
                oldFocusObject.SendMessageUpwards("OnFocusLeave", SendMessageOptions.DontRequireReceiver);

                recognizer.CancelGestures();
                recognizer.StartCapturingGestures();
            }
        }
    }
}
