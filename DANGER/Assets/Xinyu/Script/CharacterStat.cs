using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public Texture2D Portrait;

    public string ID = "P1";
    public string Name = "Tu";
    public int MaxHp = 100;
    public int CurrentHp = 75;

    public int MaxStress = 100;
    public int CurrentStress = 50;
    public Texture2D StressPicture;

    public int MaxStamina = 100;
    public int CurrentStamina = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int GetMaxHp() 
    {
        return MaxHp;
    }


    public int GetCurrentHp() 
    {
        return CurrentHp;
    }

    public int GetMaxStress()
    {
        return MaxStress;
    }

    public int GetCurrentStress()
    {
        return CurrentStress;
    }

    public int GetMaxStamina()
    {
        return MaxStamina;
    }

    public int GetCurrentStamina()
    {
        return CurrentStamina;
    }

    public string GetName()
    {
        return Name;
    }

    public string GetID()
    {
        return ID;
    }
}
