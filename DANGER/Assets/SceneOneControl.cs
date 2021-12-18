using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOneControl : MonoBehaviour
{
    //Flags

    //Objectos coleccionable
    public bool fireAlarmActived;
    public bool wetTowelGot;

    //Comportamiento
    public bool followSign;
    public bool OpenDoorCarefully;
    public bool avoidFire;

    //Quiz correcto sin fallar
    public bool quizOneCorrect;
    public bool quizTwoCorrect;
    public bool quizThreeCorrect;
    public bool quizFourCorrect;
    public bool quizFiveCorrect;

    //Flags para bloquear pasos
    public bool quizOneAnswered = false;
    public bool quizTwoAnsewed = false;
    public bool quizThreeAnswered = false;
    public bool quizFourAnswered = false;
    public bool quzFiveAnswered = false;


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (quzFiveAnswered) {
            SceneManager.LoadScene("Level1Supered");
        }
    }
}
