using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMenu_C : MonoBehaviour
{

    private Button btnStart;

    // Start is called before the first frame update
    void Start()
    {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(OnClickStart);
    }

    void OnClickStart()
    { SceneManager_C.GetInstance().ChangeScene(Scene.Main);  }
}
