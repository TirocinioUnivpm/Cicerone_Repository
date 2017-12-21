using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScriptAudio : MonoBehaviour {
    public Camera camera;
    public AudioSource mp3;
    public GameObject sfera;
    public GameObject animazione;
    public bool attivo;
    float distanzaX;
    float distanzaY;
    float distanzaZ;
    public float costanteDistanza;
    
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
        if (sfera.activeSelf)
        {
            distanzaX = (sfera.transform.position.x - camera.transform.position.x);
            distanzaY = (sfera.transform.position.y - camera.transform.position.y);
            distanzaZ = (sfera.transform.position.z - camera.transform.position.z);
            SettaDistanza(distanzaX, distanzaY, distanzaZ);


            if (InRange(distanzaX, distanzaY, distanzaZ))
            {



                mp3.Play();
                attivo = true;
                sfera.GetComponent<Renderer>().material.color = Color.yellow;
                animazione.SetActive(false);


            }
            else
            {

                //mp3.Stop();
                attivo = false;
                sfera.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log("sei troppo lontano");

            }
        }else
        {
            Debug.Log("non sono attivo");
        }
    }
    public void SettaDistanza(float x, float y, float z)
    {
        if (x < 0)
        {
            x = -x;
        }else if (y < 0)
        {
            y = -y;
        }else if (z<0)
        {
            z = -z;
        }else
        {
            Debug.Log("le posizioni sono positive");
        }
    }

    public bool InRange( float x, float y, float z)
    {
        if(x<costanteDistanza && y<costanteDistanza && z<costanteDistanza)
        {
            return true;
        }
        else
        {
            return false;
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
