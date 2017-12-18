using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptAudio : MonoBehaviour {

    public AudioSource mp3;
    public GameObject sfera;
   
    public bool attivo;
    // Use this for initialization
    void Start()
    {
        attivo = false;
    }
    void OnMouseDown()

    {
        if (!attivo)
        {
            mp3.Play();
            attivo = true;
            sfera.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            mp3.Pause();
            attivo = false;
            sfera.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
