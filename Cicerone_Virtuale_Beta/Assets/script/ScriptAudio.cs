using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptAudio : MonoBehaviour {
    public Camera cam;
    public AudioSource mp3;
    public GameObject sfera;
    //public GameObject animazione;
    private bool attivo;
    float distanzaX;
    public float costanteDistanza;
    
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    public void Start()
    {
        attivo = false;
    }

    public void Update()
    {

        distanzaX = Vector3.Distance(cam.transform.position, sfera.transform.position);


        if (distanzaX < costanteDistanza)
        {
            if (attivo == false)
            {
                mp3.Play();
                attivo = true;
                sfera.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.Log("sei vicino");
            }
            else { Debug.Log("sei vicino ma è già attivo"); }


        }
        else if(distanzaX > costanteDistanza && attivo == true)
        {
            mp3.Stop();
            attivo = false;
            sfera.GetComponent<Renderer>().material.color = Color.white;
            Debug.Log("troppo lontano tolgo audio");
        }
        else { Debug.Log("sei troppo lontano"); }

      
    }
        
}
