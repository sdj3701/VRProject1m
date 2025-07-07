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
        // Pool�� �ش� UI�� ������ ������ Ȱ��ȭ
        if (Pool.ContainsKey(name) && Pool[name].Count > 0)
        {
            Debug.Log("Not Create");
            var ui = Pool[name].Dequeue();
            ui.SetActive(true);
            return ui;
        }

        Debug.Log("Create");
        // Pool�� �ش� UI�� ���ų� ��������� ���� ����
        GameObject prefab = Resources.Load<GameObject>(name);
        GameObject uiInstance = GameObject.Instantiate(prefab, uiRoot);
        uiInstance.SetActive(true);
        Debug.Log(uiInstance.name);
        return uiInstance;

    }

    public void ReturnUI(string name, GameObject ui)
    {
        // UI�� Pool�� ��ȯ�ϰ� ��Ȱ��ȭ
        ui.SetActive(false);
        // Pool�� �ش� UI�� ������ ���� ����
        if (!Pool.ContainsKey(name))
        {
            Pool[name] = new Queue<GameObject>();
        }
        
        Pool[name].Enqueue(ui);
    }

}


/*
InputManager:
    ������ "I" Ű ����
        ��
UIManager:
    "Inventory" UI�� �ʿ��ϴٰ� ��û ����
        ��
UIPool:
    Inventory UI�� Pool�� ������ ����
    ������ Instantiate�ؼ� ����
        ��
UIManager:
    Canvas �Ʒ��� ���̰� ������
        ��
������ �ݱ� ��ư ����
        ��
UIManager:
    �ش� UI�� Pool�� �ٽ� �ݳ�

 */