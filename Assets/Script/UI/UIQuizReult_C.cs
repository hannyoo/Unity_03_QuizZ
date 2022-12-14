using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIQuizReult_C : MonoBehaviour
{
    [SerializeField] private Button btnConfirm;

    [SerializeField] private TMP_Text txtCount;
 
    [SerializeField] private TMP_Text txtScore;
    [SerializeField] private TMP_Text txtScore2;


    void Start()
    {
        btnConfirm.onClick.AddListener(() => {gameObject.SetActive(false);
        });

        txtCount.text = $"¸ÂÃá °¹¼ö : {QuizManager_C.GetInstance().correctCount}";
     
        txtScore.text = $"{QuizManager_C.GetInstance().score}";
        txtScore2.text = $"{QuizManager_C.GetInstance().score}";

    }

}
