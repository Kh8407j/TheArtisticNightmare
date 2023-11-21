// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace menuInteractable
{
    public class Door : MenuInteractable
    {
        private Animator anim;

        // Start is called before the first frame update
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            anim.SetBool("Open", Highlighted);
        }

        public override void OnClick()
        {
            // KH - Clicking on the menu door will close the application.
            base.OnClick();
            Application.Quit();
        }
    }
}