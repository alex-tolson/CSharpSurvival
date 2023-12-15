using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    void Update()
    {
        Vector3 directionToFace = _player.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.yellow);

        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
    }
}
