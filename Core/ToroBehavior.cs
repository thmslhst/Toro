using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ToroBehavior : Toro
{
    public bool randomize = true;
    public int randomMin = 0;
    public int randomMax = FFT_SIZE;
    public ToroCapacitor capacitor;
    public int FFTIndex;

    protected override void Start()
    {
        base.Start();

        if (randomize)
            Randomize();

        if (capacitor != null)
            capacitor.Fire += Randomize;
    }

    //---------------------

    protected virtual void Randomize()
    {
        FFTIndex = Random.Range(randomMin, randomMax);
    }

    //---------------------

    private void OnDrawGizmos()
    {
        if (randomMax > FFT_SIZE)
            randomMax = FFT_SIZE;
    }
}