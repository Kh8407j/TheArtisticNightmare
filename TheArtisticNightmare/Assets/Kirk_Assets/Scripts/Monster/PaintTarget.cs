// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class PaintTarget : MonoBehaviour
    {
        private bool painted;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // KH - Method to set the value of 'painted'.
        public void SetPainted(bool input)
        {
            painted = input;
        }
    }
}