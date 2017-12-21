using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptAudio : MonoBehaviour {
    public Camera camera;
    public AudioSource mp3;
    public GameObject sfera;
    public GameObject animazione;
    public bool attivo;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    public void Start()
    {
        
    }

    public void Update()
    {
        float distanza = (camera.transform.position.z - sfera.transform.position.z);

        if (distanza < 0){

            distanza = -distanza;

            }else if (distanza < 20){
        
                mp3.Play();
                attivo = true;
                sfera.GetComponent<Renderer>().material.color = Color.yellow;
                animazione.SetActive(false);


                }else{
        
                    Debug.Log("sei troppo lontano");
           
                }
    }
    void OnMouseDown()

    {
        if (attivo == false)
        {
            mp3.Play();
            attivo = true;
            sfera.GetComponent<Renderer>().material.color= Color.yellow;
            animazione.SetActive(false);
        }
        else
        {
            mp3.Pause();
            attivo = false;
            sfera.GetComponent<Renderer>().material.color = Color.white;
            animazione.SetActive(true);
        }
    }
}
