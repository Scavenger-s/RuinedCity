using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ChangeLight : VRTK_InteractableObject {

    public GameObject light1; //对应台灯中的灯 1
    public GameObject light2; //对应台灯中的灯 2
    private bool isOn = true; //开关
                         //重写 StartUsing
    public override void StartUsing(GameObject currentUsingObject)
    {
        base.StartUsing(currentUsingObject);
        if (isOn)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            isOn = false;
            Debug.Log("11");
        }
        else
        {
            light1.SetActive(true);
            light2.SetActive(true);
            isOn = true;
            Debug.Log("11");
        }
    }
}
