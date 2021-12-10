using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TeammateManager : MonoBehaviour
{
    private Canvas canvas;
    public Image[] images;

    //public Dictionary<Items.ItemType, Image> imagesDict = new Dictionary<Items.ItemType, Image>();

    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] imagesGO = GameObject.FindGameObjectsWithTag("ItemImage");
        //List<Image> images = new List<Image>();
        //Array itemType = Enum.GetValues(typeof(Items.ItemType));

        //List<Image> itemTypeList = ((int[])itemType).ToList();


        //for (int i = 0; i < imagesGO.Length; i++)
        //{
        //    for (int j = 0; j < itemType.Length; j++)
        //        imagesDict.Add(itemType.GetValue(j), imagesGO[i].GetComponent<Image>());
        //}


    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {

    }

    public void Activate(Items.ItemType it)
    {
        if (it == Items.ItemType.ALARM)
        {
            images[0].enabled = true;
        }
        else if (it == Items.ItemType.WET_TOWEL)
        {
            images[1].enabled = true;
        }
    } 
}
