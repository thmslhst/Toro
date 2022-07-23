using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroLookAt : MonoBehaviour
{
    public List<Transform> targets = new List<Transform>();
    public ToroCapacitor capacitor;
    private int _current = 0;

    void Start()
    {
        if (capacitor != null)
            capacitor.Fire += NextTarget;
    }

    void Update()
    {
        transform.LookAt(targets[_current]);
        transform.LookAt(targets[_current], Vector3.left);
    }

    private void NextTarget()
    {
        if (_current < targets.Count-1)
            _current++;
        else
            _current = 0;
    }
}