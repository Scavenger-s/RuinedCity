using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    SteamVR_TrackedObject trackedObject;
    SteamVR_Controller.Device device;
	// Use this for initialization
	void Start () {
        trackedObject = GetComponent<SteamVR_TrackedObject>();
        device = SteamVR_Controller.Input((int)trackedObject.index);
        Debug.Log("start");

    }

    // Update is called once per frame
    void Update () {
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger)) {
            Debug.Log("trigger");

        }
	}
}
