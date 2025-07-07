using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public GameObject MainUIGameOjbect; // 메뉴 UI 게임 오브젝트

    private Button ExitGamebtn;
    private Button ExitMenubtn;
    
    void Start()
    {
        // 이름으로 찾아서 Button 컴포넌트 가져오기
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
        MainUIGameOjbect.SetActive(false); // 메뉴 UI 비활성화
    }
}
