using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroDolly : MonoBehaviour
{
    public ToroCapacitor capacitor;
    public Vector3 direction;
    public Vector3 rotation;
    public bool randomize;
    public float directionSpeed = 0.03f;
    public float rotationSpeed = 0.3f;

    void Start()
    {
        if (capacitor != null)
            capacitor.Fire += Randomize;

        if (randomize)
            Randomize();
    }

    void Update()
    {
        transform.Translate(direction * (directionSpeed * Time.deltaTime));
        transform.Rotate(rotation * (rotationSpeed * Time.deltaTime));
    }

    private void Randomize()
    {
        direction = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
        rotation = new Vector3(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2));
    }
}
