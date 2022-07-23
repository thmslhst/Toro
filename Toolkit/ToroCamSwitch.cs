using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroCamSwitch : MonoBehaviour
{
    public List<Camera> cameras;
    public ToroCapacitor capacitor;
    private int currentCamIndex = 0;

    void Start()
    {
        // init cams
        foreach(Camera cam in cameras)
            cam.enabled = false;
        cameras[currentCamIndex].enabled = true;

        // capacitor callback
        if (capacitor != null)
            capacitor.Fire += Switch;
    }

    private void Switch()
    {
        cameras[currentCamIndex].enabled = false;

        if (currentCamIndex < cameras.Count-1)
            currentCamIndex++;
        else
            currentCamIndex = 0;
        cameras[currentCamIndex].enabled = true;
    }
}
