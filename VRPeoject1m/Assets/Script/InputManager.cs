using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public GameObject MainUIGameOjbect; // 메뉴 UI 게임 오브젝트
    public Transform UICanvas;
    private UIPooling uIPooling;

    private void Awake()
    {
        uIPooling = new UIPooling(UICanvas);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (MainUIGameOjbect.activeSelf == false)
                uIPooling.GetUI(MainUIGameOjbect.name);
            else
                uIPooling.ReturnUI(MainUIGameOjbect.name, MainUIGameOjbect);


        }
    }
}
