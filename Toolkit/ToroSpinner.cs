using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroSpinner : ToroBehavior
{
    public float speed = 1.0F;
    public Vector3 rotation;
    public bool randomizeRotation = false;

    protected override void Start()
    {
        base.Start();
    }
    void Update()
    {
        transform.Rotate(rotation * (getFFT(FFTIndex) * speed * Time.deltaTime));
    }

    protected override void Randomize()
    {
        base.Randomize();
        if (randomizeRotation)
            RandomizeRotation();

    }

    private void RandomizeRotation()
    {
        rotation = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }
}
