using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CallbackAction : MonoBehaviour
{
    public delegate void OnEndReached(Cube instance);
    public static event OnEndReached onEndReached;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("Checking to see if event is subscribed to");

            if (onEndReached != null)
            {
                onEndReached(other.GetComponent<Cube>());
                Debug.Log("Raising event");
            }

        }
    }


}
