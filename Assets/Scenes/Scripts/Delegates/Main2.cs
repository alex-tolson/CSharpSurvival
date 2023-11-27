using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
    public GameObject[] cubeArray;

    public delegate void ActionClick();
    public static event ActionClick onClick;

    public void ButtonClick()
    {
        onClick();
    }
}
