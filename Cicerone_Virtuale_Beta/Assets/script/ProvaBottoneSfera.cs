using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ProvaBottoneSfera : MonoBehaviour {
    Image prova;
    public Sprite spriteprova;
	// Use this for initialization
    void Start()
    {
        prova = GetComponent<Image>();
    }
	public void provaBottone()
        
    {
        prova.sprite= spriteprova;
        Debug.Log("ho cliccato");
    }
	
	
}
