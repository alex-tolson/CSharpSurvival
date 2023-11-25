using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable<int>
{
    public int health
    {
        get;
        set;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
