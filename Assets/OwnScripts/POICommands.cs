using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POICommands : MonoBehaviour {

    private GameObject plane;

    private Color initialColor;

	// Use this for initialization
	void Start () {
        initialColor = this.gameObject.GetComponent<Renderer>().material.color;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect(GameObject focusedObject)

    {
        if (focusedObject.tag == this.gameObject.tag || focusedObject.tag == "window_close")
        {
            Debug.Log("POI or window_close");
            //panels werden displayed
            var panelclose = GameObject.FindGameObjectsWithTag("panels");

            foreach (GameObject panel in panelclose)
            {
                panel.SetActive(false);
                Debug.Log("Panels werden ausgebootet");
            }
            if (focusedObject.tag != "window_close")
            { 
                //gets and activates/deactivates the ChildObject (Plane with the informations of the POI)
                try
                {
                    plane = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
                    plane.SetActive(true);
                }
                catch
                {
                    Debug.Log("No Child found");
                }
            }

        }
        Debug.Log("Object with POICommand attached selected"); 


    }

    void OnFocus()
    {
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f);
        //Debug.Log("Focused");

        this.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f);
    }

    void OnFocusLeave()
    {
        this.gameObject.GetComponent<Renderer>().material.color = initialColor;
        //Debug.Log("Focuse leave");

        this.gameObject.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = initialColor;
    }


}