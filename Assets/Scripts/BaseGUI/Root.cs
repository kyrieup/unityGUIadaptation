using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class Root : MonoBehaviour
{
    private CustomGUIControl[] allControls;
    // Start is called before the first frame update
    void Start()
    {
        allControls = this.GetComponentsInChildren<CustomGUIControl>();
    }
    //控制子对象
    private void OnGUI()
    {
        //性能优化

            allControls = this.GetComponentsInChildren<CustomGUIControl>();


        for (int i = 0; i < allControls.Length; i++)
        {
            allControls[i].DrawGUI();
        }
    }
}
