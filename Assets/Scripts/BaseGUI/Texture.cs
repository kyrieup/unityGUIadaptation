using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texture : CustomGUIControl
{
    public ScaleMode mode = ScaleMode.ScaleToFit;
    protected override void DisStyleDrawControl()
    {
        GUI.DrawTexture(guiPos.controlPos, content.image,mode);
    }

    protected override void OnStyleDrawControl()
    {
        GUI.DrawTexture(guiPos.controlPos, content.image, mode);
    }

 
 
}
