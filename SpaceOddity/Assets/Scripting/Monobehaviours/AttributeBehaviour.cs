using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Enemy
{
    public class AttributeBehaviour : MonoBehaviour
    {
        // Fields must be able to be accessed by other objects but protected from being modified - applied const

        public const int DAMAGEATTRIBUTE = 10;
        public int health = 10;
        public const int SPEEDATTRIBUTE = 10;
    }
}