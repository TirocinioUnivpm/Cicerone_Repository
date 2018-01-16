using UnityEngine;

public class FinestraDebug : MonoBehaviour
{
    TextMesh textMesh;

    // Use this for initialization
    void Start()
    {
        textMesh = gameObject.GetComponentInChildren<TextMesh>();
    }

    void OnEnable()
    {
        Application.logMessageReceived += LogMessage;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

   
    public void LogMessage(string message, string stackTrace, LogType type)
    { try {
        if (textMesh.text.Length > 30)
        {
            textMesh.text = message + "\n";
        }
        else
        {
            textMesh.text += message + "\n";
        }
    }catch ( UnassignedReferenceException e){ Debug.Log("gestita eccezione "+e); }
  } 
    
}