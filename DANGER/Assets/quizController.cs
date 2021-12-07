using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class quizController : MonoBehaviour
{
    public Text quiz;
    public Button OptionA;
    public Button OptionB;
    public Button OptionC;

    public GameObject player;
    public CharacterStat playerStat;

    int correctOpion = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStat = player.GetComponent<CharacterStat>();
    }
    
    // Update is called once per frame
    void Update()
    {
        quiz.text = "¿Cómo ayudar a una victima en llama?";
        SetOptionB("B.Hacer se que tire y puede por el suelo.");
        SetOptionC("C.Hacer que se mantenga la calma y esperar que se apague la prenda.");
    }

    public void SetQuiz(string text)
    {

    }

    public void SetOptionA(string text)
    {
        OptionA.GetComponentInChildren<Text>().text = text;
    }

    public void SetOptionB(string text)
    {
        OptionB.GetComponentInChildren<Text>().text = text;
    }

    public void SetOptionC(string text)
    {
        OptionC.GetComponentInChildren<Text>().text = text;
    }

    public void SetCorrectOption(int option)
    {
        switch (option)
        {
            case 1: 
                    OptionA.onClick.AddListener(Correct);
                    OptionB.onClick.AddListener(Incorrect);
                    OptionC.onClick.AddListener(Incorrect);
                    break;
            
            case 2: 
                    OptionA.onClick.AddListener(Incorrect);
                    OptionB.onClick.AddListener(Correct);
                    OptionC.onClick.AddListener(Incorrect);
                    break;
            
            case 3:
                    OptionA.onClick.AddListener(Incorrect);
                    OptionB.onClick.AddListener(Incorrect);
                    OptionC.onClick.AddListener(Correct);
                    break;
            default: break;
        }
    }

    void Correct()
    {

        setDefault();
    }

    void Incorrect()
    {
        playerStat.AddStress(20);
    }

    void setDefault()
    {
        OptionA.onClick.RemoveAllListeners();
        OptionB.onClick.RemoveAllListeners();
        OptionC.onClick.RemoveAllListeners();
    }

}
