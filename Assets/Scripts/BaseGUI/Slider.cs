using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_SliderType 
{ 
    Horizontal,
    Vertical,

}
public class Slider : CustomGUIControl
{
    public E_SliderType sliderType = E_SliderType.Horizontal;
    public float min=0;
    public float max=1;
    public float nowValue=0;

    public GUIStyle tu;
    protected override void DisStyleDrawControl()
    {
        switch (sliderType)
        {
            case E_SliderType.Horizontal:
                nowValue= GUI.HorizontalSlider(guiPos.controlPos, nowValue, min, max);
                break;
            case E_SliderType.Vertical:
                nowValue = GUI.VerticalSlider(guiPos.controlPos, nowValue, min, max);
                break;

        }
    }

    protected override void OnStyleDrawControl()
    {
        switch (sliderType)
        {
            case E_SliderType.Horizontal:
                nowValue = GUI.HorizontalSlider(guiPos.controlPos, nowValue, min, max,style,tu);
                break;
            case E_SliderType.Vertical:
                nowValue = GUI.VerticalSlider(guiPos.controlPos, nowValue, min, max,style,tu);
                break;

        }
    }


}
