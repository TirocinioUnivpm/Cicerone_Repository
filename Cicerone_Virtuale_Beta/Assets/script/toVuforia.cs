using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class toVuforia : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        VuforiaBehaviour.Instance.enabled = false;

    }
	public void caricaScenaVuforia(string prova_vuforia)
    {
        
        SceneManager.LoadScene(prova_vuforia);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
