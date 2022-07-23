using UnityEngine;
using System.Collections;

public class ToroCapacitor : Toro
{
    public delegate void Callback();
    public Callback Fire;

    public int FFTIndex = 0;
    public float threshold = 0.1F;
    public int capacity = 1000;

    private int charge = 0;

    void Update()
    {
        if(getFFT(FFTIndex) >= threshold)
            charge++;

        if(charge >= capacity)
        {
            Fire();
            charge = 0;
        }
    }
}
