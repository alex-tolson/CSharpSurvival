using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager_Singleton : MonoBehaviour
{
    private static UIManager_Singleton _instance;
    public static UIManager_Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject gameobject = new GameObject("UIManager");
                gameobject.AddComponent<UIManager_Singleton>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartUIing()
    {
        Debug.Log("The UIManager is ui-ing");
    }
}
