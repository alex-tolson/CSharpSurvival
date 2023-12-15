using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerArt : MonoBehaviour
{
    [SerializeField] private GameObject _badGuyPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_badGuyPrefab, Vector3.zero, Quaternion.Euler(45, 0, 1));
        }
    }
}
