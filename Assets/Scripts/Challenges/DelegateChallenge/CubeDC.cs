using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDC : MonoBehaviour
{

    private void Start()
    {
        MainDC.onClickButton += ReassignPos;
    }


    public void ReassignPos()
    {
        transform.position = new Vector3(5, 2, 0);
    }

    private void OnDisable()
    {
        MainDC.onClickButton -= ReassignPos;
    }
}
