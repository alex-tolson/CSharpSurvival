using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public delegate void OnDamageReceived(int currentHealth);
    //public static event OnDamageReceived onDamage;

    public static Action<int> onDamageReceived;

    public int health
    {
        get;
        set;
    }

    private void Start()
    {
        health = 10;
    }
    public void Damage()
    {
        health--;

        if(onDamageReceived != null)
        {
            onDamageReceived(health);
        }
    }
}
