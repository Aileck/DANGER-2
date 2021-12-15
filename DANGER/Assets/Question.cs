using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    public bool answered = false;
    public string quistion;
    public string optionA;
    public string optionB;
    public string optionC;

    public QuizExtraInfo quizExtraInfo;

    public int correcto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1) && !answered)
        {
            GameObject quizUI = GameObject.FindGameObjectWithTag("QuizUI");

            quizController quiz = quizUI.GetComponent<quizController>();
            quiz.setCanvasActive(true);

            quiz.SetQuiz(quistion, optionA, optionB, optionC, correcto, quizExtraInfo);
            answered = true;

        }
    }
    
}
