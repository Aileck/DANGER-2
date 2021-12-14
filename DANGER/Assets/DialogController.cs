using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogController : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    public Text text;
    public Button button;

    private Canvas teamUI;
    void Start()
    {
        Debug.Log("Sat");
        button.onClick.AddListener(Ok);
        teamUI = GameObject.FindGameObjectWithTag("TeamUI").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        teamUI.enabled = !GetComponent<Canvas>().isActiveAndEnabled;
    }

    void Ok()
    {
        Debug.Log("Ohhh");
        GetComponent<Canvas>().enabled = false;
        teamUI.enabled = true;
    }

}
