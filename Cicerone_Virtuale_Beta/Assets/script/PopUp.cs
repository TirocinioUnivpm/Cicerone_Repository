using UnityEngine;
using TheNextFlow.UnityPlugins;

public class PopUp : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("indietro premuto");
            avvisoUscita();
            
        }
    }


private void avvisoUscita()
    {
        Debug.Log("entrato in avvisoUscita");
        MobileNativePopups.OpenAlertDialog(
                
               ":-(", "Vuoi uscire dall'app??",
               "SI","NO", () => { Application.Quit();  }, () => { Debug.Log("è stato premuto no"); });
    }



      
        
    


 
}
