using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClose : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnSelect(GameObject focusedObject)
    {
        GameObject parent = this.transform.parent.gameObject;
        parent.SetActive(false);
        Debug.Log("parent_tag: " + parent.tag);
    }
}
