using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ToroMover : ToroBehavior
{
    public float speed = 1.0F;
    public Vector3 direction;
    public GameObject loopCollider;
    public bool randomizeDirection = false;
    private Vector3 _basePosition;

    protected override void Start()
    {
        base.Start();
        if (randomizeDirection)
            RandomizeDirection();
    }

    void Update()
    {
        transform.Translate(direction * (getFFT(FFTIndex) * (speed / 100)));
    }

    protected override void Randomize()
    {
        base.Randomize();
        if (randomizeDirection)
            RandomizeDirection();

    }

    private void RandomizeDirection()
    {
        direction = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }

    void OnTriggerExit(Collider other)
    {
        if (other == loopCollider.GetComponent<BoxCollider>())
            transform.position = _basePosition;
    }
}