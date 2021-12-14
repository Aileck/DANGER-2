using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FireAlarm : MonoBehaviour
{
    private bool actived = false;
    private AudioSource AS;
    private TeammateManager TeammateManager;
    
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        TeammateManager = GameObject.FindGameObjectWithTag("TeamUI").GetComponentInChildren<TeammateManager>();
        player = GameObject.FindGameObjectWithTag("Player");
        
        if(GetComponent<AudioSource>() != null)
            AS = GetComponent<AudioSource>();
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


                    if (EditorUtility.DisplayDialog("Has visto una alarma...", "¿Quieres acticar la alarma?", "Sí" ,"No")) {
                        actived = true;
                        AS.Play();
                        player.GetComponent<CharacterStat>().addItem(Items.ItemType.ALARM);
                        TeammateManager.Activate(Items.ItemType.ALARM);
                    }


                }
            }
            else
            {
                EditorUtility.DisplayDialog("Has visto una alarma...","La alarma ya estaba activada", "Ok");
            }
        }
    }
}
