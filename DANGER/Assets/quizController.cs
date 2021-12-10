using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class quizController : MonoBehaviour
{

    private Canvas canvas;
    private Canvas statUI;

    public Text quiz;
    public Button OptionA;
    public Button OptionB;
    public Button OptionC;

    public GameObject player;
    public CharacterStat playerStat;

    public Text countDownText;
    private string countDownString;
    private TimeController timeController;

    public GameObject otherPanel;
    public Text[] extraCountDown;
    public Image[] extraPortrait;

    public enum QuizType
    {
        QUIZ,
        ASK
    };


    //
    //Usar SetQuiz(string quiz,string optionA,string optionB,string optionC,int correctOption,QuizExtraInfo extr) para ->
    //-----------------------------------------
    //|             [quiz]                    |
    //|optionA - correcto si correctOption = 1|
    //|optionB - correcto si correctOption = 2|
    //|optionC - correcto si correctOption = 3|
    //-----------------------------------------
    //|  Si hay extra info, mostrarlo aquí    |
    //----------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerStat = player.GetComponent<CharacterStat>();

        statUI = GameObject.FindGameObjectWithTag("TeamUI").GetComponent<Canvas>();
        timeController = GameObject.FindGameObjectWithTag("TeamUI").GetComponent<TimeController>();
    }
    
    // Update is called once per frame
    void Update()
    {

        countDownString = timeController.getCountDownString();
        countDownText.text = countDownString;

    }

    public void SetQuiz(string quiz,string optionA,string optionB,string optionC,int correctOption,QuizExtraInfo extra,QuizType qt = QuizType.QUIZ)
    {
        statUI.enabled = false;

        this.quiz.text = quiz;

        SetOptionA(optionA);
        SetOptionB(optionB);
        SetOptionC(optionC);

        if (qt == QuizType.QUIZ)
            SetCorrectOption(correctOption);

        else if (qt == QuizType.ASK)
            SetChoice(correctOption);

        if (extra != null) {
            otherPanel.SetActive(true);
            double[] hps = extra.getHps();
            Sprite[] sps = extra.getPortraits();
            int i;
            for (i = 0; i < hps.Length; i++)
            {
                extraCountDown[i].text = hps[i].ToString();
                extraPortrait[i].sprite = sps[i];
            }
            while (i < extraCountDown.Length) {
                extraCountDown[i].enabled = false;
                extraPortrait[i].enabled = false;
                i++;
            }
        }
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


    public void SetChoice(int option)
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
        setCanvasActive(false);
        statUI.enabled = true;
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

    public void setCanvasActive(bool active) 
    {
        canvas.enabled = active;
    }


}
