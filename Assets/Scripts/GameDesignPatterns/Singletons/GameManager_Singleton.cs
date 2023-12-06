using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Singleton :Monosingleton<GameManager_Singleton>
{
    public override void Init()
    {
        base.Init();
        {
            DisplayInfoMethod();
        }
    }
    public void DisplayInfoMethod()
    {
        Debug.Log("Initializing and Displaying all the info");
    }
}
