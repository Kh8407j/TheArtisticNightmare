// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UiFollowMouse : MonoBehaviour
    {
        /*
        Script made using help of the following video:
        https://youtu.be/JBn9cJvTJnA?feature=shared
         */

        [SerializeField] RectTransform movingObject;
        [SerializeField] Vector3 offset;
        [SerializeField] RectTransform basisObject;
        private Camera cam;

        // Called before 'void Start()'.
        private void Awake()
        {
            cam = GetComponent<Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            MoveObject();
        }

        // Make the moving object position itself at the cursor's position on the screen.
        public void MoveObject()
        {
            Vector3 pos = Input.mousePosition + offset;
            pos.z = basisObject.position.z;
            movingObject.position = cam.ScreenToWorldPoint(pos);
        }
    }
}