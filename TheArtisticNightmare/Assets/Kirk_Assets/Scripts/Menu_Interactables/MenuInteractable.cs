// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace menuInteractable
{
    public class MenuInteractable : MonoBehaviour
    {
        [SerializeField] string messageOnMouseHighlight = "Click here!";
        [SerializeField] InteractableMessageCanvas messageCanvasBlueprint;
        [SerializeField] Vector3 messageCanvasOffset;
        private InteractableMessageCanvas messageCanvas;

        // KH - Called before 'void Start()'.
        void Awake()
        {
            GameObject h = Instantiate(messageCanvasBlueprint.gameObject, transform.position + messageCanvasOffset, Quaternion.identity);
            messageCanvas = h.GetComponent<InteractableMessageCanvas>();
            messageCanvas.SetInteractable(this);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // KH - Called when this interactable is clicked on.
        public virtual void OnClick()
        {

        }

        // KH - Method to get the value of 'messageCanvas'.
        public InteractableMessageCanvas GetMessageCanvas()
        {
            return messageCanvas;
        }
    }
}