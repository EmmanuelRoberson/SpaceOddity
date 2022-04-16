using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class testAttributes : MonoBehaviour
    {
        public GameObject player;
        public PlayerAttributeBehaviour playAtt;
        public int alacrity;
        public int speed;
        public int psp;
        
        // Start is called before the first frame update
        void Awake()
        {
            playAtt = player.GetComponent<PlayerAttributeBehaviour>();
            alacrity = playAtt.getAlacrity();
            speed = playAtt.getSpeed();
            psp = playAtt.getpsp();
            // Speed now : 30
            Debug.Log(playAtt.getSpeed());
            playAtt.setSpeed(playAtt.alterAttributeBy(speed, 45));
            // Speed now : 75
            Debug.Log(playAtt.determineHitChance(.50, speed, psp, 5));
        }
    }

}