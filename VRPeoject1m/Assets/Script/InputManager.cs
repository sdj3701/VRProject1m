using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Canvas MainUICanvas; // 메뉴 UI 캔버스
    public GameObject MainUIGameOjbect; // 메뉴 UI 게임 오브젝트

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(MainUIGameOjbect.activeSelf == false)
                MainUIGameOjbect.SetActive(true); // 메뉴 UI 활성화
            else
                MainUIGameOjbect.SetActive(false); // 메뉴 UI 비활성화
            
        }
    }
}
