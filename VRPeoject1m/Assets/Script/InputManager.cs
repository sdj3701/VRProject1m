using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Canvas MainUICanvas; // �޴� UI ĵ����
    public GameObject MainUIGameOjbect; // �޴� UI ���� ������Ʈ

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(MainUIGameOjbect.activeSelf == false)
                MainUIGameOjbect.SetActive(true); // �޴� UI Ȱ��ȭ
            else
                MainUIGameOjbect.SetActive(false); // �޴� UI ��Ȱ��ȭ
            
        }
    }
}
