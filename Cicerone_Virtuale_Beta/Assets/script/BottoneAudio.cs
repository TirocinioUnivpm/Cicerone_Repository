using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottoneAudio : MonoBehaviour {
    Image myImageComponent;
    public Sprite myFirstImage; 
    public Sprite mySecondImage;
    public AudioSource mp3;
    bool attivo;
    // Use this for initialization
    void Start () {
        myImageComponent = GetComponent<Image>();
        attivo = true;

    }
    public void Restart()
    {
        myImageComponent.sprite = myFirstImage;
        attivo = true;
    }
    public void SetImage() //method to set our first image
    {
        if (attivo)
        {
            myImageComponent.sprite = mySecondImage;
            attivo = false;
            mp3.Pause();
        }
        else
        {
            myImageComponent.sprite = myFirstImage;
            attivo = true;
            mp3.Play();
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
    }

