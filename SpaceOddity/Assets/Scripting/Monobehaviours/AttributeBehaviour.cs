using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Enemy
{
    public class AttributeBehaviour : MonoBehaviour
    {
        // Fields must be able to be accessed by other objects but protected from being modified - applied const

        // Primary stats. Public for now to play around with values in game.
        // Physical
        public int strength;
        public int psp;
        public int resilience;
        public int speed;

        // Mental
        public int esp;
        public int charm;
        public int alacrity;

        // Getters and setters for when values are private. 
        /* 
         * When values are made private, we can omit these function and replace the values with something like
         * 'public int speed = { get; set; } ...Maybe. How to assign starting value then?
        */

        // Getters
        public int getStrength() { return strength; }
        public int getpsp() { return psp; }
        public int getResilience() { return resilience; }
        public int getSpeed() { return speed; }
        public int getEsp() { return esp; }
        public int getCharm() { return charm; }
        public int getAlacrity() { return alacrity; }

        // Setters
        public void setStrength(int strength) { this.strength = strength; }
        public void setpsp(int psp) { this.psp = psp; }
        public void setResilience(int resilience) { this.resilience = resilience; }
        public void setSpeed(int speed) { this.speed = speed; }
        public void setEsp(int esp) { this.esp = esp; }
        public void setCharm(int charm) { this.charm = charm; }
        public void setAlacrity(int alacrity) { this.alacrity = alacrity; }


        // To alter values
        public int alterAttributeBy(int attribute, int value)
        {
            int newValue = attribute + value;
            return newValue;
        }

    }
}