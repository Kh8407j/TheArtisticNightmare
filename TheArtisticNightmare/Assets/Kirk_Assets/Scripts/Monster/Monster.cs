// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class Monster : MonoBehaviour
    {
        [Header("Sanity Effect Settings")]
        [SerializeField][Range(0f, 100f)] float increaseSanityReward = 5f;
        [SerializeField][Range(0.001f, 100f)] float decreasePlayerRate = 0.02f;
        [SerializeField][Range(0.001f, 1f)] float decreaseSanityTimeDelay = 0.1f;

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

        }
    }
}