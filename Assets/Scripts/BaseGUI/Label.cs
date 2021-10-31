using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Label : CustomGUIControl
{
    protected override void DisStyleDrawControl()
    {
        GUI.Label(guiPos.controlPos, content);
    }

    protected override void OnStyleDrawControl()
    {
        GUI.Label(guiPos.controlPos, content,style);
    }
}
