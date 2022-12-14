using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum QuizType
{ History,    Math,    Korean}


public class QuizManager_C : MonoBehaviour
{
    #region Singletone

    private static QuizManager_C instance;
    public static QuizManager_C GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@QuizManager");
            instance = go.AddComponent<QuizManager_C>();

            DontDestroyOnLoad(go);
        }
        return instance;
    }
    #endregion

    public Dictionary<int, Quiz[]> quizList;

    public int quizListIdx = 0;

    public int score;
    public int correctCount;

    void Awake()
    { InitQuizList(); }

    private void InitQuizList()
    {
        quizList = new Dictionary<int, Quiz[]>();
        quizList.Add(1, new Quiz[]
        {
            new Quiz("1-1번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3" }),
            new Quiz("1-2번 문제", 20, 0, new string[]{ "답 1", "답 2" }),
            new Quiz("1-3번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3" }),
            new Quiz("1-4번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3", "답 4" })
        });

        quizList.Add(2, new Quiz[]
        {
            new Quiz("2-1번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3" }),
            new Quiz("2-2번 문제", 20, 0, new string[]{ "답 1", "답 2" }),
            new Quiz("2-3번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3" }),
            new Quiz("2-4번 문제", 20, 0, new string[]{ "답 1", "답 2", "답 3", "답 4" })
        });
    }

    public void SetQuizList(int quizList)
    { quizListIdx = quizList; }

    public Quiz[] GetQuizList()
    { return quizList[quizListIdx]; }
}
