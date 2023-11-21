// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace menuInteractable
{
    public class Bed : MenuInteractable
    {
        [SerializeField] ParticleSystem particles;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - When the bed is highlighted, emit sleep particles.
            if(Highlighted)
            {
                if(particles.isStopped)
                    particles.Play();
            }
            else if(!Highlighted)
            {
                if (particles.isPlaying)
                    particles.Stop();
            }

        }

        public override void OnClick()
        {
            base.OnClick();
        }
    }
}