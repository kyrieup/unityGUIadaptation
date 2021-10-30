using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGUIControl : MonoBehaviour
{
   
    public CustomGUI guiPos;
    public GUIStyle style;
    public GUIContent content;
    public bool isStyle;

    private void OnGUI()
    {
        if (isStyle)
        {
            OnStyleDrawControl();
        }
        else
        {
            DisStyleDrawControl();
        }
    }

    protected virtual void OnStyleDrawControl() 
    {
        GUI.Button(guiPos.controlPos, content, style);
      
    }

    protected virtual void DisStyleDrawControl()
    {
        GUI.Button(guiPos.controlPos, content);

    }
}
