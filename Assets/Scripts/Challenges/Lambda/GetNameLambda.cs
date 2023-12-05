using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNameLambda : MonoBehaviour
{
    ///<summary>
    ///Create a delegate of type int that returns the length of the gameObject's name
    ///</summary>

    public Func<int> onGetName;

    private void Start()
    {
        onGetName = () => this.gameObject.name.Length;

        int characterCount = onGetName();

        Debug.Log("Character count: " + characterCount);
    }
    //public int GetName()
    //{
    //    return this.gameObject.name.Length;
    //}
}
