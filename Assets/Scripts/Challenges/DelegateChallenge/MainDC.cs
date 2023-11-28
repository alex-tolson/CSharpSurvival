using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static MainDC;

public class MainDC : MonoBehaviour
{
    public delegate void ClickButton();
    public static event ClickButton onClickButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onClickButton != null)
            {
                onClickButton();
            }
        }
    }
}
