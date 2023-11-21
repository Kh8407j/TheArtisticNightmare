// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace menuInteractable
{
    public class InteractableMessageCanvas : MonoBehaviour
    {
        private Text text;
        private Light light;
        private Animator anim;
        private MenuInteractable interactable;
        private Camera cam;
        private Canvas canvas;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            text = GetComponentInChildren<Text>();
            light = GetComponentInChildren<Light>();
            anim = GetComponent<Animator>();
            cam = Camera.main;
            canvas = GetComponent<Canvas>();
            canvas.worldCamera = cam;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            anim.SetBool("Showing", interactable.Highlighted);
            transform.LookAt(cam.transform);
            transform.Rotate(0f, 180f, 0f);
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

        // KH - Method to set the colour of the light.
        public void SetGlowColour(Color color)
        {
            light.color = color;
        }
    }
}