using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // Current of damage a character can do
    protected float _damage;

    // Current amount of health points a character has
    protected float _health;

    // Amount of health regenerated per in-game hour
    protected float _healthRegenerated;

    // How many actions the character can preform before turn is over
    protected int _actionPoints;

    // Order priority for turn queue
    protected float _turnSequence;

    // Max number of action points this character can have
    protected int _maxActionPoints;

    // Amount of action points regenerated per turn
    protected float _actionPointRegeneration;

    // Affects damage taken from TakeDamage()
    protected float _resistance;

    // Likelihood of successfully attacking
    protected double _successfulAttackChance;

    // Likelihood of attacking critically
    protected double _criticalAttackChance;

    // Likelihood of evading damage
    protected double damageEvasionChance;

    // Range at which a character can detect an enemy
    protected double _detectionRange;

    // Amount of other characters in the party
    protected int partySize;

    protected List<Character> _partyMembers;


    //protected float Attack(Character defender);
    //protected float Attack(Character defender, float damageAmount);

    //protected float TakeDamage(float damageReceived);

    //protected float Move();

    protected void InitializeCharacter(int strength, int psp, int resilience, int speed, int esp, int charm, int alacrity)
    {
        _health = (resilience * 10) + (strength * 5);

        _detectionRange = 2 + (psp + esp);

        _resistance = (0.5f * resilience);

        _healthRegenerated = (.25f * resilience);

        _turnSequence = (alacrity * speed);

    }
}
