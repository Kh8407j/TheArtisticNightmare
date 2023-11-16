// KHOGDEN 001115381
using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class PaintTarget : MonoBehaviour
    {
        private bool painted;
        private Renderer render;
        private Monster monster;

        [Header("Debug Settings")]
        [SerializeField] bool changeMaterialOnPainted;
        [SerializeField] Material paintedMat;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            render = GetComponent<Renderer>();
            monster = GetComponentInParent<Monster>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // KH - Register the paint target as successfully painted on.
        public void Paint()
        {
            painted = true;

            // KH - If all the monster's targets are painted, convert it to a positive memory.
            if(monster.AllTargetsPainted())
                monster.ConvertToPositive();

            // KH - Change material on painted if debug setting is enabled.
            if (changeMaterialOnPainted)
                render.material = paintedMat;
        }

        // KH - Method to check if the target has been painted or not.
        public bool IsPainted()
        {
            return painted;
        }
    }
}