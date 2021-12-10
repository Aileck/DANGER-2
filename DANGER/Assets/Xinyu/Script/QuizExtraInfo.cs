using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizExtraInfo : MonoBehaviour
{
    // Una clase simplemente para almacenar informaci¨®n extra de Quiz
    public double[] HPs;
    public Sprite[] portraits;
    public Items.ItemType[] ItemsToCheck;

    public string infoToShowOnFail;
    public Sprite pictureToShowOnFail;


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


    public Items.ItemType[] getItemsToCheck()
    {
        return ItemsToCheck;
    }

    public Sprite getPicture()
    {
        return pictureToShowOnFail;
    }

    public string getInfo()
    {
        return infoToShowOnFail;
    }
}
