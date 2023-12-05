using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger_Singleton : MonoBehaviour
{
    public GameObject cube;

    private static SpawnManger_Singleton _instance;
    public static SpawnManger_Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject gameobject = new GameObject("SpawnManager");
                gameobject.AddComponent<SpawnManger_Singleton>();
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void StartSpawning()
    {
        Debug.Log("Spawning has been initiated");
        GameObject go0 = Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject go1 = Instantiate(cube, new Vector3(2, 2, 0), Quaternion.identity);
        GameObject go2 = Instantiate(cube, new Vector3(-2, -2, 0), Quaternion.identity);

    }
}
