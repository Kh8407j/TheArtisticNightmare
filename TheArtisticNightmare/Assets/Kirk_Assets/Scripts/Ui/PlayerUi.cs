// KHOGDEN 001115381
using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PlayerUi : MonoBehaviour
    {

        [SerializeField] Slider sanityMeter;
        private Sanity playerSanity;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            playerSanity = player.GetComponent<Sanity>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Continuouly display the player's current sanity on the meter.
            sanityMeter.value = playerSanity.GetSanity();
            sanityMeter.maxValue = playerSanity.GetMaxSanity();
        }
    }
}