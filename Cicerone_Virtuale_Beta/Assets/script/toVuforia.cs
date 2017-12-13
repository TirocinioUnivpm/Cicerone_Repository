
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class ToVuforia : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        VuforiaBehaviour.Instance.enabled = false;

    }
	public void caricaScenaVuforia()
    {
         if (PlayerPrefs.GetInt("isFirstTime") != 1)
          {
              SceneManager.LoadScene("guida");
              PlayerPrefs.SetInt("isFirstTime", 1);
              PlayerPrefs.Save();

          }
          else
          {
              SceneManager.LoadScene("prova vuforia");
            
          }
        //SceneManager.LoadScene("prova vuforia");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
