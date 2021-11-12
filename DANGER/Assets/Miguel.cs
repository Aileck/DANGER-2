using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miguel : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.ForceSoftware;
    public Vector2 hotSpot = Vector2.zero;

    public GameObject Interact;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        Interact.SetActive(true);
        //if (Input.GetMouseButtonDown(1))
        //{
            //Posici車n bot車n
            //Debug.Log("Tengo sed...");


        //}
    }

    void OnMouseExit()
    {
        Interact.SetActive(false);
        //Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    void OnMouseOver()
    {

        //if (Input.GetMouseButtonDown(1))
        //{
            //Posici車n bot車n
            //Debug.Log("Miguel? Parece herido.");


        //}
    }
}
