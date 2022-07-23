using UnityEngine;
using System.Collections;

namespace ToroTools
{
    public class ToroAlphaFluffer : ToroBehavior
    {
        private Renderer r;

        protected override void Start()
        {
            base.Start();
            r = GetComponent<Renderer>();
        }

        void Update()
        {
            r.material.SetFloat("_Cutoff", getFFT(FFTIndex));
        }
    }
}
