using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReturnSumLambda : MonoBehaviour
{
    /// <summary>
    /// Create a delegate of type int that takes 2 numbers as a parameter and adds the sum
    /// </summary>

    public Func<int, int, int> onCalculateSum;
    void Start()
    {
        onCalculateSum = (a, b) => a + b;

        Debug.Log(onCalculateSum(5,5));
    }


}
