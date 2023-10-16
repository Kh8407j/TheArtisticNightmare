// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class Sanity : MonoBehaviour
    {
        [SerializeField] float sanity = 100f;
        private float maxSanity;

        [Header("Sanity Decay Settings")]
        [SerializeField][Range(0.01f, 100f)] float decayRate = 1f;
        [SerializeField][Range(0.01f, 1f)] float decayTime = 0.1f;
        private float decayTimer;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            maxSanity = sanity;
            decayTimer = decayTime;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Decrease the sanity decay timer until it reaches zero.
            if(decayTimer > 0f)
                decayTimer -= Time.deltaTime;
            else if(decayTimer <= 0f)
            {
                // KH - Reduce sanity by the decay rate when timer reaches zero.
                decayTimer = decayTime;
                AddSanity(-decayRate);
            }
        }

        // KH - Increase or decrease the player's sanity.
        public void AddSanity(float add)
        {
            // KH - Add/subtract the inputted amount to the player's sanity.
            sanity += add;

            // KH - Did the sanity go up or down?
            if(add > 0f)
            {
                // KH - If the sanity went up.

                // KH - Make sure sanity doesn't go past the maximum value.
                if(sanity > maxSanity)
                    sanity = maxSanity;
            }
            else
            {
                // KH - If the sanity went down.

                // KH - Make sure sanity doesn't go into negative values.
                if (sanity < 0f)
                    sanity = 0f;
            }
        }

        public float GetSanity()
        {
            return sanity;
        }

        public float GetMaxSanity()
        {
            return maxSanity;
        }
    }
}