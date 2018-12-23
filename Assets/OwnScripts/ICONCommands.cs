using System.Collections; using System.Collections.Generic; using UnityEngine;  public class ICONCommands : MonoBehaviour {      private GameObject plane;     public Camera mainCamera;      //private Color initialColor;  	// Use this for initialization 	void Start () {         this.mainCamera = Camera.main;         //initialColor = this.gameObject.GetComponent<Renderer>().material.color;     } 	 	// Update is called once per frame 	void Update () {          transform.LookAt(mainCamera.transform); 		 	}      void OnSelect(GameObject focusedObject){

        //if (focusedObject.tag == "window_close")
        //{
            //focusedObject.gameObject.transform.parent.gameObject.SetActive(false);
            //GameObject test = focusedObject.gameObject.transform.parent.transform.gameObject;
            //test.SetActive(false);

            // panels are displayed when clicked on tracks will get disabled
            //var panelclose = GameObject.FindGameObjectsWithTag("panels");

            //foreach (GameObject panel in panelclose)
            //{
                //panel.SetActive(false);
                //Debug.Log("panel disabled by click");

            //}

            //Debug.Log("window_close tapped");
        //}

        //Debug.Log("Tag: " + focusedObject.tag);
    }


    //void OnSelect()
    //{
    //gets and activates/deactivates the ChildObject (Plane with the informations of the POI)

    //plane = this.gameObject.transform.GetChild(0).gameObject;
    //plane.SetActive(!plane.activeSelf);
    //Debug.Log("SelectIcon");

    //}

    /*void OnFocus()     {        this.gameObject.GetComponent<Renderer>().material.color = new Color(1f, 0f, 1f);        Debug.Log("Focused");     }      void OnFocusLeave()     {         this.gameObject.GetComponent<Renderer>().material.color = initialColor;         Debug.Log("Focuse leave");     } */

}