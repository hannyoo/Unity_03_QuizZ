using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMain_C : MonoBehaviour
{
    [SerializeField] private Button btnConS;
    [SerializeField] private Button btnNonS;

    void Start()
    {
        btnConS.onClick.AddListener(() => {
            OnSelectQuizeList(1);
        });

        btnNonS.onClick.AddListener(() => {
            OnSelectQuizeList(2);
        });
    }

    void OnSelectQuizeList(int quizListIdx)
    {
        QuizManager_C.GetInstance().SetQuizList(quizListIdx);
        SceneManager_C.GetInstance().ChangeScene(Scene.Quiz);
    }
}
