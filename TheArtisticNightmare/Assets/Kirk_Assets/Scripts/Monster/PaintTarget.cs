// KHOGDEN 001115381
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class PaintTarget : MonoBehaviour
    {
        private bool painted;
        private Renderer render;

        [Header("Debug Settings")]
        [SerializeField] bool changeMaterialOnPainted;
        [SerializeField] Material paintedMat;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            render = GetComponent<Renderer>();
        }

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

            // KH - Change material on painted if debug setting is enabled.
            if(changeMaterialOnPainted)
                render.material = paintedMat;
        }
    }
}