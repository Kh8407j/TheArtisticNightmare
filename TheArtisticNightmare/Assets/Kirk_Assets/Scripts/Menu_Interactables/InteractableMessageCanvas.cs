// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace menuInteractable
{
    public class InteractableMessageCanvas : MonoBehaviour
    {
        private bool showing;
        private Text text;
        private Animator anim;
        private MenuInteractable interactable;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            text = GetComponentInChildren<Text>();
            anim = GetComponent<Animator>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            anim.SetBool("ShowMessage", showMessage);
        }

        // KH - Method to get or set the value of 'showing'.
        public bool Showing
        {
            get { return showing; }
            set { showing = value; }
        }

        // KH - Method to set the highlight message text.
        public void SetMessage(string message)
        {
            text.text = message;
        }

        // KH - Method to set the value of 'interactable'.
        public void SetInteractable(MenuInteractable input)
        {
            interactable = input;
        }
    }
}