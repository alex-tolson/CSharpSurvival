using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    private int _currentHealth;
    private int _maxHealth = 100;
    private float _speed = 5;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }
    public void Damage()
    {

    }
}
