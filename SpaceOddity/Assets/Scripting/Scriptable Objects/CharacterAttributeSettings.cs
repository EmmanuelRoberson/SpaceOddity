using System.Collections;
using System.Collections.Generic;
using Enemy;
using UnityEngine;

[CreateAssetMenu(menuName = "Character Stats")]
public class CharacterAttributeSettings : ScriptableObject
{
    // Physical
    public int strength;    //hp, melee damage
    public int psp;         //detection range, hit%
    public int resilience;  //hp, resistance, hp regeneration
    public int speed;       //hit%, ap, ts, max ap

    // Mental
    public int esp;         //detection range, crit%
    public int charm;       //party size, buffs
    public int alacrity;    //de%, ts, ap regen, max ap, ap
}
