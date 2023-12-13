using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerObserver : MonoBehaviour
{
    public static event Action onTurnRed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space was pressed");
            onTurnRed?.Invoke();
        }
    }
}
 