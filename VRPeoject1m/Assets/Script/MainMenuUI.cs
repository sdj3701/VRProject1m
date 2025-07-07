using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public GameObject MainUIGameOjbect; // �޴� UI ���� ������Ʈ

    private Button ExitGamebtn;
    private Button ExitMenubtn;
    
    void Start()
    {
        // �̸����� ã�Ƽ� Button ������Ʈ ��������
        ExitGamebtn = GameObject.Find("GameExitButton").GetComponent<Button>();
        ExitMenubtn = GameObject.Find("MenuExitButton").GetComponent<Button>();

        ExitGamebtn.onClick.AddListener(() =>
        {
            ExitGame();
        });

        ExitMenubtn.onClick.AddListener(() =>
        {
            ExitMenu();
        });
    }

    private void ExitGame()
    {
        Debug.Log("Exit Game");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void ExitMenu()
    {
        Debug.Log("Exit Menu");
        MainUIGameOjbect.SetActive(false); // �޴� UI ��Ȱ��ȭ
    }
}
