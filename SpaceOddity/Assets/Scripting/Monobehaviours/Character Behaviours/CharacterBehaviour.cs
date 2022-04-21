using System.Collections;
using System.Collections.Generic;
using Enemy;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    // Default player stats
    [SerializeField] private CharacterAttributeSettings _characterAttributeSettings;

    private AttributeBehaviour characterAttributes;



    // Start is called before the first frame update
    void Start()
    {
        InitializeAttributes();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Gives value to all the attributes on character attributes using _characterAttributeSettings
    private void InitializeAttributes()
    {
        //physical attributes
        characterAttributes.setStrength(_characterAttributeSettings.strength);
        characterAttributes.setpsp(_characterAttributeSettings.psp);
        characterAttributes.setResilience(_characterAttributeSettings.resilience);

        //mental attributes
        characterAttributes.setSpeed(_characterAttributeSettings.speed);
        characterAttributes.setEsp(_characterAttributeSettings.esp);
        characterAttributes.setCharm(_characterAttributeSettings.charm);
        characterAttributes.setAlacrity(_characterAttributeSettings.alacrity);
    }


    // Calculates and assigns health 
    private void InitializeCombatStats()
    {

    }

    // Stat Getters
    public int Strength
    {
        get => characterAttributes.getStrength();
    }

    public int Psp
    {
        get => characterAttributes.getpsp();
    }

    public int Resilience
    {
        get => characterAttributes.getResilience();
    }

    public int Speed
    {
        get => characterAttributes.getSpeed();
    }

    public int Esp
    {
        get => characterAttributes.getEsp();
    }

    public int Charm
    {
        get => characterAttributes.getCharm();
    }

    public int Alacrity
    {
        get => characterAttributes.getAlacrity();
    }


}
