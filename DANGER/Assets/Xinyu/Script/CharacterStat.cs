using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStat : MonoBehaviour
{
    public double MaxHp = 100;
    public double CurrentHp = 75;

    public double MaxStress = 100;
    public double CurrentStress = 50;
    public Texture2D StressPicture;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check Game Over
        if (CurrentHp <= 0) {
            CurrentHp = MaxHp;
        }
        CurrentStress += 0.02;
        if (CurrentStress >= MaxStress)
        {
            CurrentHp -= 10;
            CurrentStress = 0;
        }
    }


    public double GetMaxHp() 
    {
        return MaxHp;
    }


    public double GetCurrentHp() 
    {
        return CurrentHp;
    }

    public double GetMaxStress()
    {
        return MaxStress;
    }

    public double GetCurrentStress()
    {
        return CurrentStress;
    }


    public void AddHp(double i) 
    {
        CurrentHp += i;
    }

    public void LossHp(double i)
    {
        CurrentHp -= i;
    }

    public void AddStress(double i)
    {
        CurrentStress += i;
    }

    public void LossStress(double i) 
    {
        CurrentHp -= i;
    }


}
