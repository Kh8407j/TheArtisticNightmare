// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class LoseMeter : MonoBehaviour
    {
        [SerializeField] float loseRate = 100f;
        private float maxLoseRate;

        [Header("Lose Rate Decay Settings")]
        [SerializeField][Range(0.01f, 100f)] float decayRate = 1f;
        [SerializeField][Range(0.01f, 1f)] float decayTime = 0.1f;
        private float decayTimer;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            maxLoseRate = loseRate;
            decayTimer = decayTime;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Decrease the lose-rate decay timer until it reaches zero.
            if(decayTimer > 0f)
                decayTimer -= Time.deltaTime;
            else if(decayTimer <= 0f)
            {
                // KH - Reduce lose-rate by the decay rate when timer reaches zero.
                decayTimer = decayTime;
                AddSanity(-decayRate);
            }
        }

        // KH - Increase or decrease the player's lose-rate.
        public void AddSanity(float add)
        {
            // KH - Add/subtract the inputted amount to the player's lose-rate.
            loseRate += add;

            // KH - Did the lose-rate go up or down?
            if (add > 0f)
            {
                // KH - If the lose-rate went up.

                // KH - Make sure lose-rate doesn't go past the maximum value.
                if (loseRate > maxLoseRate)
                    loseRate = maxLoseRate;
            }
            else
            {
                // KH - If the lose-rate went down.

                // KH - Make sure lose-rate doesn't go into negative values.
                if (loseRate < 0f)
                    loseRate = 0f;
            }
        }

        public float GetLoseRate()
        {
            return loseRate;
        }

        public float GetMaxLoseRate()
        {
            return maxLoseRate;
        }
    }
}