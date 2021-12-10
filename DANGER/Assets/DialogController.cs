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
    void Start()
    {
        button.onClick.AddListener(Ok);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Ok()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
