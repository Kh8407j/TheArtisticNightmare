// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace menuInteractable
{
    public class MenuMouse : MonoBehaviour
    {
        private MenuInteractable highlight;
        private menuInteractable lastHighlighted;
        private Camera cam;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            cam = GetComponent<Camera>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            highlight = CheckMouseHighlight();
            highlight.GetMessageCanvas().Showing = true;

            // KH - Check that the user's mouse has stopped highlighting this menu item.
            if (lastHighlighted != highlight)
                lastHighlighted.GetMessageCanvas().Showing = false;

            lastHighlighted = highlight;
        }

        // KH - Method to check if the mouse is highlighting a interactable, returning it.
        public MenuInteractable CheckMouseHighlight()
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // KH - Fire a raycast towards where the user's mouse is.
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                MenuInteractable m = hit.transform.gameObject.GetComponent<MenuInteractable>();

                // KH - Check that the raycast has hit a interactable menu item.
                if (m != null)
                    return m;
            }

            return null;
        }
    }
}