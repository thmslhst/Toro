using UnityEngine;
using System.Collections;

public class ToroVectorInjecter : ToroBehavior
{
    private Renderer r;

    protected override void Start()
    {
        base.Start();
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        r.material.SetFloat("ToroVector", getFFT(FFTIndex));
    }
}