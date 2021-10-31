using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Toggle : CustomGUIControl
{
    public bool isSelection;
    private bool oldSelection;
    public event UnityAction<bool> ChangeEvent;
    protected override void DisStyleDrawControl()
    {
       isSelection = GUI.Toggle(guiPos.controlPos, isSelection, content);
        if (oldSelection!=isSelection)
        {
            ChangeEvent?.Invoke(isSelection);
            oldSelection = isSelection;
        }
    }

    protected override void OnStyleDrawControl()
    {
        isSelection = GUI.Toggle(guiPos.controlPos, isSelection, content,style);
        if (oldSelection != isSelection)
        {
            ChangeEvent?.Invoke(isSelection);
            oldSelection = isSelection;
        }
    }
}
