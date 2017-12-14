using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ListaimmaginiIntro : MonoBehaviour {
    Image myImageComponent;
    public Sprite myFirstImage; //Drag your first sprite here in inspector.
    public Sprite mySecondImage; //Drag your second sprite here in inspector.
    public Sprite myThirdImage;
  
    void Start() //Lets start by getting a reference to our image component.
    {
        myImageComponent = GetComponent<Image>(); //Our image component is the one attached to this gameObject.
        
       
    }

    public void SetImage(float i) //method to set our first image
    {
        if (i == 0)
        {
            myImageComponent.sprite = myFirstImage;

        }else if (i == 1)
        {
            myImageComponent.sprite = mySecondImage;
        }
        else
        {
            myImageComponent.sprite = myThirdImage;
        }
        
    }

   

}
