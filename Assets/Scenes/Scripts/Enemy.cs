using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<float>
{
    public int health 
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
