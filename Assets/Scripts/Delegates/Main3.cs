using System;
using UnityEngine;

public class Main3 : MonoBehaviour
{
    //create a program that takes in a string and returns the length of it. (How many characters) 

    public Func<string, int> CharacterLength;

    void Start()
    {
        CharacterLength = (phrase) => name.Length;

        int count = CharacterLength("CountDracula");
        Debug.Log("Character Count: " + count);
    }
}
