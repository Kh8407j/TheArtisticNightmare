// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace misc
{
    public class GameState : MonoBehaviour
    {
        public static GameState instance;
        private enum State { playing, paused, gameOver };

        // Called before 'void Start()'.
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

        }
    }
}