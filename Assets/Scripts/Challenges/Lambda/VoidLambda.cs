using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidLambda : MonoBehaviour
{
    ///<summary>
    ///// Create a delegate of type void that has no parameters and returns the gameObject's name
    ///</summary>


    public Action onGetName;
    private void Start()
    {
        onGetName = () => Debug.Log("Name: " + gameObject.name);
        onGetName();
    }

    //void GetName()
    //{ 
    //    Debug.Log("Name: " + gameObject.name);
    //}
}
