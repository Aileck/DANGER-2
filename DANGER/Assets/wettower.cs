using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class wettower : MonoBehaviour
{
    // Start is called before the first frame update
    private bool actived = false;
    private TeammateManager TeammateManager;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        TeammateManager = GameObject.FindGameObjectWithTag("TeamUI").GetComponentInChildren<TeammateManager>();
        player = GameObject.FindGameObjectWithTag("Player");       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (actived == false)
            {
                if (Input.GetMouseButtonDown(1))
                {


                    if (EditorUtility.DisplayDialog("Has visto una sadasdas...", "¿Quieres llevar sacsdcas?", "Sí", "No"))
                    {
                        actived = true;
                        player.GetComponent<CharacterStat>().addItem(Items.ItemType.WET_TOWEL);
                        TeammateManager.Activate(Items.ItemType.WET_TOWEL);
                    }


                }
            }
            else
            {
                EditorUtility.DisplayDialog("Has visto una alarma...", "La alarma ya estaba activada", "Ok");
            }
        }
    }
}
