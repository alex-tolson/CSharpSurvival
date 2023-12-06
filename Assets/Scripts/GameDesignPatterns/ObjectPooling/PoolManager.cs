using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private GameObject _bulletContainer;

    [SerializeField] private bool _bulletsEmpty = false;
    [SerializeField] private List<GameObject> _pooledBullets;
 


    //turn this class into a singleton for easy accessibility
    private static PoolManager _instance;
    public static PoolManager Instance
    {
        get
        {
            if (_instance == null)
            { 
                Debug.LogError("Pool Manager is Null");
            }

            return _instance;
        }
    }
    private void Start()
    {
        _pooledBullets = GenerateBullets(10);
    }

    private void Awake()
    {
        _instance = this;

    }

    private List<GameObject> GenerateBullets(int amountOfBullets)
    {
        for (int i = 0; i < amountOfBullets; i++)
        {
            GameObject go = Instantiate(_bulletPrefab, _bulletContainer.transform);
            go.SetActive(false);
            _pooledBullets.Add(go);
        }

        return _pooledBullets;
    }

    public GameObject RequestBullet()
    {
        for (int i = 0; i < _pooledBullets.Count; i++)
        {

            if (_pooledBullets[i].activeInHierarchy == false)
            {
                _pooledBullets[i].SetActive(true);

                return _pooledBullets[i];
            }
            else
            {
                _bulletsEmpty = _pooledBullets.All(_pooledBullets => _pooledBullets.activeInHierarchy == true);

                if (_bulletsEmpty == true)
                {
                    return MakeMoreBullet();
                }
            }

        }
        return null;
    }
    private GameObject MakeMoreBullet()
    {

        GameObject newbullet = Instantiate(_bulletPrefab, _bulletContainer.transform);
        _pooledBullets.Add(newbullet);
        return newbullet;

    }
}
