
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class CambiaScena : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        VuforiaBehaviour.Instance.enabled = false;

    }
    public void caricaScenaVuforia()
    {
        if (PlayerPrefs.GetInt("isFirstTime") != 1)
        {
            SceneManager.LoadScene("Intro");
            PlayerPrefs.SetInt("isFirstTime", 1);
            PlayerPrefs.Save();

        }
        else
        {
            SceneManager.LoadScene("VuforiaScene");

        }
        //SceneManager.LoadScene("prova vuforia");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
