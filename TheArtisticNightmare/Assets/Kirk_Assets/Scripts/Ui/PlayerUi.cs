// KHOGDEN 001115381
using managers;
using player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class PlayerUi : MonoBehaviour
    {
        [SerializeField] Text winTime;
        [SerializeField] Slider loseMeter;
        private LoseMeter lose;

        // KH - Called before 'void Start()'.
        private void Awake()
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            lose = player.GetComponent<LoseMeter>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // KH - Display how much time left the player has till they win.
            winTime.text = Mathf.Round(SessionManager.instance.GetWinTime()).ToString();

            // KH - Display the player's current rate to losing on the meter.
            loseMeter.value = lose.GetLoseRate();
            loseMeter.maxValue = lose.GetMaxLoseRate();
        }
    }
}