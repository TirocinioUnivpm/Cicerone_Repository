using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class PopUpBack : MonoBehaviour {

    /*private void Start()
    {
        bool focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!focusModeSet)
        {
            Debug.Log("Failed to set focus mode to continusauto (unsupported mode).");
        }
    }*/

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("indietro premuto");
            avvisoRitornoPagIniz();

        }
    }


    private void avvisoRitornoPagIniz()
    {
        Debug.Log("entrato in avvisoRitornoPAGINIZ");
        TheNextFlow.UnityPlugins.MobileNativePopups.OpenAlertDialog(

               ":-(", "cosa vuoi fare?",
               "Torna al menù", "Esci", () => { SceneManager.LoadScene("prova pagina iniziale cicerone"); }, () => { Application.Quit(); });
    }

}
