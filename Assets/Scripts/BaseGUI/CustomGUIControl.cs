using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomGUIControl : MonoBehaviour
{
   
    public CustomGUI guiPos;
    public GUIStyle style;
    public GUIContent content;
    public bool isStyle;

    public void DrawGUI()
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

    protected abstract void OnStyleDrawControl();


    protected abstract void DisStyleDrawControl();
}
