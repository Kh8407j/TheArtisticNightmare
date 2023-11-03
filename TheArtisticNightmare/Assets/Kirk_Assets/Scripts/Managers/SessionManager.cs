// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace managers
{
    public class SessionManager : MonoBehaviour
    {
        public static SessionManager instance;

        [SerializeField][Range(1f, 360f)] float winTime = 120f;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Keep tickind down the win time until it reaches zero.
            if (winTime > 0f)
                winTime -= Time.deltaTime;
            else if (winTime < 0f)
                winTime = 0f;
        }

        public float GetWinTime()
        {
            return winTime;
        }
    }
}