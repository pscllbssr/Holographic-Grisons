﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class TrackHandler : MonoBehaviour {     private GameObject[] tracks;     private Color initialColor;     private Color tempColor;     private Renderer rend;      // Use this for initialization     void Start () {          initialColor = GetComponent<Renderer>().material.color;     } 	 	// Update is called once per frame 	void Update () { 		 	}      void OnSelect()     {                  tracks = GameObject.FindGameObjectsWithTag("Track");         foreach(GameObject track in tracks)         {             if(track.name != gameObject.name)             {                 tempColor = track.GetComponent<Renderer>().material.color;                 tempColor.g = 0f;                 tempColor.r = 0f;                 tempColor.b = 1f;                 tempColor.a = 0.1f;                 track.GetComponent<Renderer>().material.color = tempColor;             }             else track.GetComponent<Renderer>().material.color = initialColor;          }       } } 