using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour {
    public bool on;
    public Camera cameraVuforia;
    public Camera cameraScroll;

    // Use this for initialization
    void OnMouseDown(){

        if (on)
        {
            cameraVuforia.enabled = false;
            cameraScroll.enabled = true;
            on = false;
        }
        else
        {
            cameraVuforia.enabled = true;
            cameraScroll.enabled = false;
            on = true;
        }
		
	}
	
	// Update is called once per frame
	
}
