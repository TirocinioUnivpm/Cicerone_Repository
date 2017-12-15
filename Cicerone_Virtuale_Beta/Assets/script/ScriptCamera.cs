using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScriptCamera : MonoBehaviour {
    public bool on;
    public Camera cameraVuforia;
    public Camera cameraScroll;
    
    void OnMouseDown(){

        if (on)
        {
          cameraVuforia.enabled = false;
            cameraScroll.enabled = true;
            VuforiaBehaviour.Instance.enabled = false;
            on = false;
        }
        else
        {
          cameraVuforia.enabled = true;
            cameraScroll.enabled = false;
            VuforiaBehaviour.Instance.enabled = true;
            on = true;
        }
		
	}
	
	// Update is called once per frame
	
}
