using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class toglistat : MonoBehaviour {

	// Use this for initialization
	void Start () {
        VuforiaBehaviour.Instance.enabled = true;
        PlayerPrefs.SetInt("isFirstTime", 0);
        PlayerPrefs.Save();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
