// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using monster;

namespace player
{
    public class FPSController : MonoBehaviour
    {
        [SerializeField] GameObject paintSplash;
        [SerializeField][Range(0.01f, 1f)] float holdFireTime = 0.1f;
        private float holdFireTimer;

        private Camera cam;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            cam = GetComponentInChildren<Camera>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Fire the paintball gun whenever the player presses down fire.
            if (Input.GetButton("Fire1"))
                Fire();

            // KH - Decrease hold fire timer. Prevent going past negative for easier referencing.
            if(holdFireTimer > 0f)
                holdFireTimer -= Time.deltaTime;
            else if(holdFireTimer < 0f)
                holdFireTimer = 0f;
        }

        // KH - Fire the player's gun towards where the mouse cursor is pointing.
        void Fire()
        {
            /* KH - Thank you to 'lulutube14' from Unity Forums! for Raycast assistance.
             https://forum.unity.com/threads/how-to-raycast-from-camera-through-mouse-position.293717/ */

            // KH - Shoot a raycast from the player camera to the mouse click position.
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 1000f))
            {
                // KH - Check that delay time has reached zero before registering fire.
                if (holdFireTimer == 0f)
                {
                    // KH - Apply delay for next time player fires.
                    holdFireTimer = holdFireTime;

                    // KH - Debug fire circles to show where player has fired.
                    GameObject obj = Instantiate(paintSplash, hit.point, Quaternion.identity);
                    Destroy(obj, 2f);

                    // KH - Check that the player has successfully hit a target.
                    if (hit.transform != null)
                    {
                        RegisterHit(hit.transform);
                    }
                }
            }
        }

        // KH - Called by 'void Fire()' when a target is successfully hit.
        void RegisterHit(Transform hit)
        {
            // KH - Check that the target was a paintable target.
            if(hit.CompareTag("PaintTarget"))
            {
                // KH - Set the paintable target as painted.
                PaintTarget target = hit.gameObject.GetComponent<PaintTarget>();
                target.SetPainted(true);
            }
        }
    }
}