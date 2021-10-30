using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Pos 
{ 
    Up,
    Down,
    Left,
    Right,
    Center,
    Left_Up,
    Right_Up,
    Left_down,
    Right_down,

}
/// <summary>
/// 处理控件位置
/// </summary>
[System.Serializable]
public class CustomGUI
{
    private Rect pos = new Rect(0, 0, 100, 100);
    //屏幕对齐方式
    public E_Pos sceen_Alignment_Pos = E_Pos.Center;
    //控件对齐方式
    public E_Pos control_Center_Alignment_pos = E_Pos.Center;
    //偏移的变量
    public Vector2 rePos;
    //控件的宽和高
    public float width = 100;
    public float height = 50;

    public Vector2 controlCenter;
    private void AllControllCenter() 
    {
        switch (control_Center_Alignment_pos)
        {
            case E_Pos.Up:
                controlCenter.x = -width / 2;
                controlCenter.y = 0;
                break;
            case E_Pos.Down:
                controlCenter.x = -width / 2;
                controlCenter.y = -height;
                break;
            case E_Pos.Left:
                controlCenter.x = 0;
                controlCenter.y = -height / 2;
                break;
            case E_Pos.Right:
                controlCenter.x = -width;
                controlCenter.y = -height / 2;
                break;
            case E_Pos.Center:
                controlCenter.x = -width / 2;
                controlCenter.y = -height / 2;
                break;
            case E_Pos.Left_Up:
                controlCenter.x = 0;
                controlCenter.y = 0;
                break;
            case E_Pos.Right_Up:
                controlCenter.x = -width;
                controlCenter.y = 0;
                break;
            case E_Pos.Left_down:
                controlCenter.x = 0;
                controlCenter.y = -height;
                break;
            case E_Pos.Right_down:
                controlCenter.x = -width;
                controlCenter.y = -height;
                break;
        }

    }

    private void AllScreenCenter() 
    {
        switch (sceen_Alignment_Pos)
        {
            case E_Pos.Up:
                pos.x = Screen.width / 2 + controlCenter.x + rePos.x;
                pos.y = 0 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Down:
                pos.x = Screen.width / 2 + controlCenter.x + rePos.x;
                pos.y = Screen.height + controlCenter.y + rePos.y;
                break;
            case E_Pos.Left:
                pos.x = 0 + controlCenter.x + rePos.x;
                pos.y = Screen.height/2 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Right:
                pos.x = Screen.width + controlCenter.x + rePos.x;
                pos.y = Screen.height/2 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Center:
                pos.x = Screen.width/2 + controlCenter.x + rePos.x;
                pos.y = Screen.height / 2 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Left_Up:
                pos.x = 0 + controlCenter.x + rePos.x;
                pos.y = 0 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Right_Up:
                pos.x = Screen.width + controlCenter.x + rePos.x;
                pos.y = 0 + controlCenter.y + rePos.y;
                break;
            case E_Pos.Left_down:
                pos.x = 0 + controlCenter.x + rePos.x;
                pos.y = Screen.height + controlCenter.y + rePos.y;
                break;
            case E_Pos.Right_down:
                pos.x = Screen.width + controlCenter.x + rePos.x;
                pos.y = Screen.height + controlCenter.y + rePos.y;
                break;

        }

    }
    public Rect controlPos 
    {
        get
        {
            //控件中心点
            AllControllCenter();

            //最终位置
            AllScreenCenter();

            pos.width = width;
            pos.height = height;
            
            return pos;
        }
    
    }
}
