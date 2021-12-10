using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizExtraInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public double[] HPs;
    public Sprite[] portraits;
    public Items.ItemType[] ItemToCheck;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public double[] getHps (){
        return HPs;
    }

    public Sprite[] getPortraits()
    {
        return portraits;
    }


    public Items.ItemType[] ToCheck()
    {
        return ItemToCheck;
    }

}
