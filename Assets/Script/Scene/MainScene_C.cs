using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene_C : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager_C.GetInstance().SetEventSystem();
        UIManager_C.GetInstance().OpenUI("UIMain");

        if (SceneManager_C.GetInstance().prevScene == Scene.Quiz)
        {  UIManager_C.GetInstance().OpenUI("UIResult"); }
    }
    
}
