using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjPoolEx : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    private Vector3 randomPlace;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { randomPlace = new Vector3(Random.Range(-9f, 9f), Random.Range(-6f, 6f), 0f);
            GameObject go = Instantiate(_bullet, randomPlace, Quaternion.identity);
        }
    }
}
