using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumLambda : MonoBehaviour
{
    //public delegate void SumOfTwo(float num1, float num2);
    //SumOfTwo calculation;

    public Action<int, int> Sum;

    // Start is called before the first frame update
    void Start()
    {
        Sum = (num1, num2) =>
        {
            var total = num1 + num2;
            Debug.Log("Sum equals " + total);
        };
        
        Sum(5,90);
    }


}
