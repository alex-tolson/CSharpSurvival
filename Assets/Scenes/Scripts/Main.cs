using UnityEngine;


public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color color);
    public ChangeColor onColorChange;


    public delegate void CompletedTask();
    public CompletedTask onComplete;

    private void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);

        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        if (onComplete != null)
        {
            onComplete();
        }
    }


    public void UpdateColor (Color newColor)
    {
        Debug.Log("Changing color to " + newColor.ToString());
    }

    public void Task()
    {
        Debug.Log("Task 1 finished.");
    }

    public void Task2()
    {
        Debug.Log("Task 2 finished.");
    }

    public void Task3()
    {
        Debug.Log("Task 3 finished.");
    }
}