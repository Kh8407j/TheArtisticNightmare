// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;

namespace monster
{
    public class Monster : MonoBehaviour
    {
        [Header("Lose Rate Settings")]
        [SerializeField][Range(0.001f, 100f)] float decreaseLoseRate = 0.02f;
        [SerializeField][Range(0.001f, 1f)] float decreaseLoseRateDelay = 0.1f;
        private float decreaseLoseRateTimer;

        [Header("On Convert to Positive Memory")]
        [SerializeField][Range(0f, 10f)] float increaseLoseRate = 3f;

        // Variables/references relating to the monster's painted status.
        private bool positiveMemory;
        private PaintTarget[] paintTargets;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            paintTargets = GetComponentsInChildren<PaintTarget>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Continuously decrease timer until it reaches zero.
            if(decreaseLoseRateTimer > 0f)
                decreaseLoseRateTimer -= Time.deltaTime;
            else if(decreaseLoseRateTimer < 0f)
                decreaseLoseRateTimer = 0f;

            // KH - Decrease player's lose rate and reset timer back to zero.
            if (decreaseLoseRateTimer == 0f)
            {
                decreaseLoseRateTimer = decreaseLoseRateDelay;
                LoseMeter.instance.AddLoseRate(-decreaseLoseRate);
            }

        }

        // KH - Convert the monster into a positive memory.
        public void ConvertToPositive()
        {
            // KH - Check that the monster isn't already a positive memory.
            if (!positiveMemory)
            {
                positiveMemory = true;

                // KH - Add time to the player's lose rate as a reward.
                LoseMeter.instance.AddLoseRate(increaseLoseRate);
            }
        }

        // KH - Method to see if all the enemy's paint targets have been painted.
        public bool AllTargetsPainted()
        {
            // KH - If one of the enemy's paint targets still needs to be painted, return false.
            foreach(PaintTarget target in paintTargets)
            {
                if (!target.IsPainted())
                    return false;
            }

            // KH - Return true if no unpainted targets could be found.
            return true;
        }
    }
}