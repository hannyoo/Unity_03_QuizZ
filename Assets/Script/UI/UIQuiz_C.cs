using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIQuiz_C : MonoBehaviour
{
    [SerializeField] private TMP_Text txtQuiz;

    [SerializeField] private Button[] btnAnswers;
    [SerializeField] private TMP_Text[] txtAnswers;

    int quizIdx;

   
    Quiz[] quizList;      //퀴즈 리스트는 배열형태[] 
    Quiz quizTxt;         //퀴즈 배열[] 내부의 퀴즈를 불려오기 위해서

    void Start()
    {
        for (int i = 0; i < btnAnswers.Length; i++)
        {
            int curIdx = i;
            btnAnswers[curIdx].onClick.AddListener(() => {
                OnAswer(curIdx);
            });
        }

        StartQuiz();
    }

    private void StartQuiz()
    {
        QuizManager_C.GetInstance().correctCount = 0;
        QuizManager_C.GetInstance().score = 0;

        quizList = QuizManager_C.GetInstance().GetQuizList();
        quizIdx = 0;

        RefreshUI();
    }

    private void NextQuiz()
    {
        quizIdx++;
        if (quizList.Length > quizIdx)
        {   RefreshUI();   }
        else
        { SceneManager_C.GetInstance().ChangeScene(Scene.Main);  }
    }

    private void RefreshUI()
    {
        quizTxt = quizList[quizIdx];

        txtQuiz.text = quizTxt.question;
        for (int i = 0; i < btnAnswers.Length; i++)
        {
            if (quizTxt.answerList.Length > i)
            {
                btnAnswers[i].gameObject.SetActive(true);
                txtAnswers[i].text = quizTxt.answerList[i];
            }
            else
            {  btnAnswers[i].gameObject.SetActive(false);  }
        }
    }

    private void OnAswer(int idx)
    {
        if (quizList[quizIdx].correctAnswerIdx == idx)
        {
            QuizManager_C.GetInstance().correctCount++;
            QuizManager_C.GetInstance().score += quizList[quizIdx].score;
        }

        NextQuiz();
    }
}
