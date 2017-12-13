using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToVuforia : MonoBehaviour {

    // Use this for initialization
    public void CaricaScenaVuforia()
    {
        SceneManager.LoadScene("VuforiaScene");
    }
}
