using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGroup : MonoBehaviour
{
    public Toggle[] toggles;
    private Toggle oldTrueToggle;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < toggles.Length; i++)
        {
            Toggle temp = toggles[i];
            toggles[i].ChangeEvent += (value) =>
            {
                if (value)
                {
                    oldTrueToggle = temp;
                    for (int j = 0; j < toggles.Length; j++)
                    {
                        if (toggles[j]!=temp)
                        {
                            toggles[j].isSelection = false;
                        }
                    }
                }
                else
                {
                    if (temp==oldTrueToggle)
                    {
                        temp.isSelection = true;
                    }
                }

            };
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
