using UnityEngine;
using System.Collections;

namespace ToroTools
{
    public class ToroSkinStreamer : ToroBehavior
    {
        public float speed = 1.0F;
        private Vector2 flow;
        private Renderer r;

        protected override void Start()
        {
            base.Start();
            r = GetComponent<Renderer>();
        }

        void Update()
        {
            flow.y += getFFT(FFTIndex) * (speed / 100);
            r.material.SetTextureOffset("_BaseMap", flow);
        }
    }
}
