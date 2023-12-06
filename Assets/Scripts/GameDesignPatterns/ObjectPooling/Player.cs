using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 randomPlace;
    [SerializeField] private GameObject _bulletPrefab;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { randomPlace = new Vector3(Random.Range(-9f, 9f), Random.Range(-6f, 6f), 0f);
            GameObject bullet = PoolManager.Instance.RequestBullet();
            bullet.transform.position = Vector3.zero;

        }
    }
}
