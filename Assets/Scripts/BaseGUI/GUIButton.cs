using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GUIButton : CustomGUIControl
{

    public event UnityAction clickEvent;
    protected override void DisStyleDrawControl()
    {
        if (GUI.Button(guiPos.controlPos,content))
        {
            clickEvent?.Invoke();
        }
    }

    protected override void OnStyleDrawControl()
    {
        if (GUI.Button(guiPos.controlPos, content,style))
        {
            clickEvent?.Invoke();
        }
    }

}
