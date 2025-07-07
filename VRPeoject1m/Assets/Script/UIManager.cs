using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager IUiManager = null;

    public static UIManager Instance
    {
        get
        {
            if (IUiManager == null)
            {
                IUiManager = FindObjectOfType<UIManager>();
                if (IUiManager == null)
                {
                    GameObject uiManagerObject = new GameObject("UIManager");
                    IUiManager = uiManagerObject.AddComponent<UIManager>();
                }
            }
            return IUiManager;
        }
    }

    // UI Manager ½Ì±ÛÅæ »ý¼º  
    void Awake()
    {
        if (IUiManager == null)
        {
            IUiManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }




}
