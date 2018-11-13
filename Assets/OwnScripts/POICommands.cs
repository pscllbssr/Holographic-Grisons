using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POICommands : MonoBehaviour {

    //private Transform plane;
    public GameObject plane;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect()
    {
        //plane = transform.GetChild(0);
        //plane.gameObject.SetActive(!plane.gameObject.activeSelf);

        plane.SetActive(!plane.activeSelf);

    }
}