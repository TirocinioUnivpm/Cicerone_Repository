using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sfera : MonoBehaviour {
    public GameObject pannello;
    public GameObject animazione;
    public GameObject sfera;

    // Use this for initialization
    void OnMouseDown()
    {
        if (pannello.activeSelf)
        {
            sfera.GetComponent<Renderer>().material.color = Color.yellow;
            pannello.SetActive(false);
            animazione.SetActive(false);
        }
        else {

            sfera.GetComponent<Renderer>().material.color = Color.white;
            pannello.SetActive(true);
            animazione.SetActive(true);


        }
       
        
    }
}
