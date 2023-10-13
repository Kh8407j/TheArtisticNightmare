// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;

        // Called before 'void Start()'.
        private void Awake()
        {
            // Allow GM to transfer between scenes while avoiding any duplicates.
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
                Destroy(gameObject);
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