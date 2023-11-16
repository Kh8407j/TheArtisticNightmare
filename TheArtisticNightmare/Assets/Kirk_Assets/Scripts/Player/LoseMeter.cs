// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class LoseMeter : MonoBehaviour
    {
        public static LoseMeter instance;

        // The lose rate. When this reaches zero, the player receives game over.
        [SerializeField] float loseRate = 100f;
        private float maxLoseRate;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            instance = this;
            maxLoseRate = loseRate;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // KH - Increase or decrease the player's lose-rate.
        public void AddLoseRate(float add)
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