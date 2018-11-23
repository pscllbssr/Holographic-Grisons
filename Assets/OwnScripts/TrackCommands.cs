using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class TrackCommands : MonoBehaviour {

    private Color ownColor;
    private Color initialColor;
    public bool selected;

	// Use this for initialization
	void Start () {
        selected = false;
        ownColor = this.gameObject.GetComponent<Renderer>().material.color;
        initialColor = new Color(0xFE, 0xED, 0xDE, 0xFF);
        this.gameObject.GetComponent<Renderer>().material.color = initialColor;

    }
	
	// Update is called once per frame
	void Update () {


    }

    void OnFocus()
    {
        this.gameObject.GetComponent<Renderer>().material.color = ownColor;
        Debug.Log("Focused");
    }

    void OnFocusLeave()
    {
        if (!selected)
        {
            this.gameObject.GetComponent<Renderer>().material.color = initialColor;
            Debug.Log("Focuse leave");
        }     }

    void OnSelect()
    {
        selected = true;

    }
}
