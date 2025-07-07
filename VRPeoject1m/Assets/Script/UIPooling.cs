using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPooling : MonoBehaviour
{
    private Dictionary<string, Queue<GameObject>> Pool = new Dictionary<string, Queue<GameObject>>();
    private Transform uiRoot;

    public UIPooling(Transform root)
    {
        uiRoot = root;
    }

    public GameObject GetUI(string name)
    {
        // Pool에 해당 UI가 있으면 꺼내서 활성화
        if (Pool.ContainsKey(name) && Pool[name].Count > 0)
        {
            Debug.Log("Not Create");
            var ui = Pool[name].Dequeue();
            ui.SetActive(true);
            return ui;
        }

        Debug.Log("Create");
        // Pool에 해당 UI가 없거나 비어있으면 새로 생성
        GameObject prefab = Resources.Load<GameObject>(name);
        GameObject uiInstance = GameObject.Instantiate(prefab, uiRoot);
        uiInstance.SetActive(true);
        Debug.Log(uiInstance.name);
        return uiInstance;

    }

    public void ReturnUI(string name, GameObject ui)
    {
        // UI를 Pool에 반환하고 비활성화
        ui.SetActive(false);
        // Pool에 해당 UI가 없으면 새로 생성
        if (!Pool.ContainsKey(name))
        {
            Pool[name] = new Queue<GameObject>();
        }
        
        Pool[name].Enqueue(ui);
    }

}


/*
InputManager:
    유저가 "I" 키 누름
        ↓
UIManager:
    "Inventory" UI가 필요하다고 요청 받음
        ↓
UIPool:
    Inventory UI가 Pool에 있으면 꺼냄
    없으면 Instantiate해서 생성
        ↓
UIManager:
    Canvas 아래에 붙이고 보여줌
        ↓
유저가 닫기 버튼 누름
        ↓
UIManager:
    해당 UI를 Pool로 다시 반납

 */