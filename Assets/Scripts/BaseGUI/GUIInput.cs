using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GUIInput : CustomGUIControl
{
    private string oldString;

    public event UnityAction<string> isChangeString;
    protected override void DisStyleDrawControl()
    {
       content.text= GUI.TextField(guiPos.controlPos, content.text);
        if (oldString!=content.text)
        {
            isChangeString?.Invoke(content.text);
            oldString = content.text;
        }
    }

    protected override void OnStyleDrawControl()
    {
        content.text = GUI.TextField(guiPos.controlPos, content.text,style);
        if (oldString != content.text)
        {
            isChangeString?.Invoke(content.text);
            oldString = content.text;
        }
    }
}
