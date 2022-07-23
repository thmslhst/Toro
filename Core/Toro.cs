using UnityEngine;
using System.Collections;

public abstract class Toro : MonoBehaviour
{
    protected const int FFT_SIZE = 128;
    protected OtoroEater oe;

    //---------------------

    protected virtual void Start()
    {
        GameObject go = GameObject.Find("Otoro Eater");
        oe = go.GetComponent<OtoroEater>();
    }

    //---------------------

    protected float getFFT(int index)
    {
        return oe.getFFT(index);
    }
}