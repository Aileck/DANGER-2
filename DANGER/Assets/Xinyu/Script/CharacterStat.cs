using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterStat : MonoBehaviour
{
    public GameObject TemperatureDetector;

    public double MaxHp = 100;
    public double CurrentHp = 75;
    private double HpLostPerFrame = 0;

    public double MaxStress = 100;
    public double CurrentStress = 50;
    private double StressGainPerFrame = 0.015;

    private List<Items.ItemType> ItemList = new List<Items.ItemType>();


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

        CurrentStress += StressGainPerFrame;
        CurrentHp -= HpLostPerFrame;

        if (CurrentStress >= MaxStress)
        {
            CurrentHp -= 5;
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

    public List<Items.ItemType> GetItemList()
    {
        return ItemList;
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

    public void addItem(Items.ItemType it)
    {
        ItemList.Add(it);
        if (it == Items.ItemType.ALARM)
        {
            StressGainPerFrame -= 0.005;
        }
    }

    public void LostItem(Items.ItemType it)
    {
        if(ItemList.Contains(it))
            ItemList.Remove(it);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Si hemos entrado a zona peligro
        if (other.tag == "Fire")
        {
            TemperatureDetector.GetComponent<MeshRenderer>().enabled = true;
            TemperatureDetector.GetComponent<TemperatureDetector>().ChangeMaterialRed();
            HpLostPerFrame += 0.015;
            StressGainPerFrame += 0.015;

        }
        else if (other.tag == "DangerFire")
        {
            TemperatureDetector.GetComponent<MeshRenderer>().enabled = true;
            TemperatureDetector.GetComponent<TemperatureDetector>().ChangeMaterialOrange();
            StressGainPerFrame += 0.005;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fire")
        {
            Debug.Log("Sale de fueg9");
            TemperatureDetector.GetComponent<TemperatureDetector>().ChangeMaterialOrange();
            HpLostPerFrame -= 0.015;
            StressGainPerFrame -= 0.015;

        }
        else if (other.tag == "DangerFire")
        {
            Debug.Log("Sale de peligto");
            TemperatureDetector.GetComponent<MeshRenderer>().enabled = false;
            StressGainPerFrame -= 0.005;

        }
    }
}
