using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class DistinctExample : MonoBehaviour
{

    public string[] names = { "tom", "tiffany", "Bartholomew", "dimi", "dimitri", "tom", 
        "pete", "cody", "dimi", "harry", "jesse", "patrick", "clause", "pete" };


    void Start()
    {
        int arrayCount = 0;
        var uniqueNames = names.Distinct();

        foreach (var name in uniqueNames)
        {
            arrayCount++;

            Debug.Log("Name: " + name);
        }
        Debug.Log("Array count is " + arrayCount);
    }


    void Update()
    {
        
    }
}
