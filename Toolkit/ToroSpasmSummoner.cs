using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToroSpasmSummoner : MonoBehaviour
{
    public ToroCapacitor capacitor;
    public string animationName;
    public Animation anim;

    void Start()
    {
        if (capacitor != null)
            capacitor.Fire += Play;

        anim = gameObject.GetComponent<Animation>();
    }

    void Play()
    {
        anim.Play(animationName);
    }
}
