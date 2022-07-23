using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroBulbBubbler: ToroBehavior
{
    public float offset = 1.0f;
    public float intensity = 1.0f;
    private Light _light;

    protected override void Start()
    {
        base.Start();
        _light = GetComponent<Light>();
    }

    void Update()
    {
        _light.intensity = offset + (intensity * getFFT(FFTIndex));
    }
}
