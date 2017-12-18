using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornaVuforia : MonoBehaviour {
    public Camera cameraVuforia;
    public Camera cameraScroll;
    // Use this for initialization
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            cameraVuforia.gameObject.SetActive(true);
            cameraScroll.gameObject.SetActive(false);

        }
    }
}
