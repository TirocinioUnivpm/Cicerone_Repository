using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sfera : MonoBehaviour {
    public GameObject text;
    // Use this for initialization
    void OnMouseDown()
    {
        if (text.activeSelf)
        {
            text.SetActive(false);

        }
        else {

            text.SetActive(true);

        }
       
        
    }
}
