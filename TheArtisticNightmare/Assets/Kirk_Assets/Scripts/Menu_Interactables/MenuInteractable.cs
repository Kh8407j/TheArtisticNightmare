// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace menuInteractable
{
    public class MenuInteractable : MonoBehaviour
    {
        [SerializeField] string messageOnMouseHighlight = "Click here!";
        [SerializeField] Color glowColour;
        [SerializeField] InteractableMessageCanvas messageCanvasBlueprint;
        [SerializeField] Vector3 messageCanvasOffset;
        private InteractableMessageCanvas messageCanvas;
        private bool highlighted;

        // KH - Called before 'void Start()'.
        void Awake()
        {
            GameObject h = Instantiate(messageCanvasBlueprint.gameObject, transform.position + messageCanvasOffset, Quaternion.identity);
            messageCanvas = h.GetComponent<InteractableMessageCanvas>();
            messageCanvas.SetInteractable(this);
            messageCanvas.SetMessage(messageOnMouseHighlight);
            messageCanvas.SetGlowColour(glowColour);
        }

        // KH - Called when this interactable is clicked on.
        public virtual void OnClick()
        {

        }

        // KH - Method to get or set the value of 'highlighted'.
        public bool Highlighted
        {
            get { return highlighted; }
            set { highlighted = value; }
        }
    }
}