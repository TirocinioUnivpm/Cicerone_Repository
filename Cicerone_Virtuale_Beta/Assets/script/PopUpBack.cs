using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpBack : MonoBehaviour {

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

               ":-(", "Vuoi ritornare alla pagina iniziale?",
               "SI", "NO", () => { SceneManager.LoadScene("prova pagina iniziale cicerone"); }, () => { Debug.Log("è stato premuto no"); });
    }

}
