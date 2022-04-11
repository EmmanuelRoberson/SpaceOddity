using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player {
    public class testAttributes : MonoBehaviour
    {
        GameObject player;
        PlayerAttributeBehaviour playAtt;
        public int alacrity;
        
        // Start is called before the first frame update
        void Start()
        {
            playAtt = player.GetComponent<PlayerAttributeBehaviour>();
            alacrity = playAtt.alacrity;
            Debug.Log(alacrity);
        }
    }

}