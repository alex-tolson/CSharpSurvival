using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{

    private GameObject _cube;
    private Color _color;
    private Color _previousColor;
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }

    void ICommand.Execute()
    {

        _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    void ICommand.Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColor;

    }
}
