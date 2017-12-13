using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visto : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("isFirstTime", 1);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
