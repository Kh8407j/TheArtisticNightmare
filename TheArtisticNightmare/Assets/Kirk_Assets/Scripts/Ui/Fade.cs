// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class Fade : MonoBehaviour
    {
        public static Fade instance;
        [SerializeField] bool fadeOut;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // KH - Make the application screen fade in or out.
        public void ToggleFade(bool screenFadeOut)
        {
            fadeOut = screenFadeOut;
        }

        // KH - Method to see if screen has faded out or in.
        public bool IsFadeOut()
        {
            return fadeOut;
        }
    }
}