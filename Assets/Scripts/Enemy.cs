using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    public float health 
    { 
        get; 
        set; 
    }
    public void Damage(float damageAmount)
    {
        //health -= damageAmount;

        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
