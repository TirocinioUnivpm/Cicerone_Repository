using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ScriptCamera : MonoBehaviour {
    
    public Camera cameraVuforia;
    public Camera cameraScroll;
    
    void OnMouseDown(){

        if (cameraVuforia.gameObject.activeInHierarchy)
        {
            cameraVuforia.gameObject.SetActive(false);
            cameraScroll.gameObject.SetActive(true);
            
            
        }
        else
        {
            cameraVuforia.gameObject.SetActive(true);
            cameraScroll.gameObject.SetActive(false);
        }
		
	}
	
	// Update is called once per frame
	
}
