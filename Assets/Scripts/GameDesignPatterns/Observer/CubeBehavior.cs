using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    Material _mesh;
    private void OnEnable()
    {
        _mesh = GetComponent<MeshRenderer>().material;
        PlayerObserver.onTurnRed += PlayerObserver_onTurnRed;      
    }

    private void OnDisable()
    {
        PlayerObserver.onTurnRed -= PlayerObserver_onTurnRed;
    }

    private void PlayerObserver_onTurnRed()
    {
        _mesh.color = Color.red;
    }
}
