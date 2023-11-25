using UnityEngine;


public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color color);

    public ChangeColor onColorChange;
}