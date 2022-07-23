using UnityEngine;
using System.Collections;

public class ToroSpasmSpammer: ToroBehavior
{
    private Animator anim;

    protected override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetFloat("speed", getFFT(FFTIndex));
    }
}