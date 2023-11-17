// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class FadeUi : MonoBehaviour
    {
        private Animator anim;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            anim.SetBool("FadeOut", Fade.instance.IsFadeOut());
        }
    }
}