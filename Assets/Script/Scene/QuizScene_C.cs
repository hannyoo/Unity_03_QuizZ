using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizScene_C : MonoBehaviour
{
    void Start()
    {
        UIManager_C.GetInstance().SetEventSystem();
        UIManager_C.GetInstance().OpenUI("UIQuiz");
    }
}
