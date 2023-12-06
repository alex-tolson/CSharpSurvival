using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monosingleton<T> : MonoBehaviour where T : Monosingleton<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError(typeof(T).ToString() + " is NULL");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this as T;

        Init();
    }

    public virtual void Init()
    {
        //Method used to initialize something(s) 
        //Optional to Override
    }

}