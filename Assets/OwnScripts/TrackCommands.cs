using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class TrackCommands : MonoBehaviour
{

    private Color ownColor;
    private Color initialColor;
    public bool selected;
    private GameObject poi;
 


    // Use this for initialization
    void Start()
    {
        selected = false;
        ownColor = this.gameObject.GetComponent<Renderer>().material.color;
        initialColor = new Color(0xFE, 0xED, 0xDE, 0xFF);
        this.gameObject.GetComponent<Renderer>().material.color = initialColor;

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnFocus()
    {
        this.gameObject.GetComponent<Renderer>().material.color = ownColor;
        //Debug.Log("Focused");
    }

    void OnFocusLeave()
    {
        if (!selected)
        {
            this.gameObject.GetComponent<Renderer>().material.color = initialColor;
            //Debug.Log("Focuse leave");
        }
    }

    void Activate(GameObject focusedObject)
    {
        if (focusedObject.tag == this.gameObject.tag)
        {
            // panels are displayed when clicked on tracks^will get disabled
            var panelclose = GameObject.FindGameObjectsWithTag("panels");

            foreach (GameObject panel in panelclose)
            {
                panel.SetActive(false);
                Debug.Log("panel disabled by track");

            }


            // deselect other tracks
            GameObject[] gos;
            gos = GameObject.FindGameObjectsWithTag("Track");
            foreach (GameObject go in gos)
            {
                if (go.GetInstanceID() != this.gameObject.GetInstanceID())
                {
                    
                    var trackCommands = go.GetComponent<TrackCommands>();
                    trackCommands.Deactivate();

                }
                else
                {
                    Debug.Log("Same same: " + this.gameObject.GetInstanceID());
                }

            }

            selected = !selected;


            // activate child icons
            foreach (Transform child in transform)
            {
                poi = child.gameObject;
                poi.SetActive(!poi.activeSelf);

                Debug.Log("Child of track activated");
            }
        }

        Debug.Log("Track with track commands script selected");
    }

    void OnSelect(GameObject focusedObject)
    {
        this.Activate(focusedObject);
        
    }

    void Deactivate()
    {
        this.GetComponent<Renderer>().material.color = initialColor;
        this.selected = false;

        foreach (Transform child in transform)
        {
            poi = child.gameObject;
            poi.SetActive(false);

            Debug.Log("Child of track deactivated");
        }

    }
}
