using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if (_instance== null)
            {
                Debug.LogError("CommandManager is null");
                
            }
            return _instance;

        }
    }
    private List<ICommand> _commandBuffer = new List<ICommand>();

    public void AddClick(ICommand click)
    {
        _commandBuffer.Add(click);

    }

    public void PlayClicks()
    {
        StartCoroutine(WaitPlayCo());
    }

    IEnumerator WaitPlayCo()
    {
        foreach (var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1f);
        }
    }

    public void Rewind()
    {
        var reverseCommandBuffer = _commandBuffer.Reverse<ICommand>();
        StartCoroutine(WaitRewindCo(reverseCommandBuffer));

    }
    IEnumerator WaitRewindCo(IEnumerable reverseBuffer)
    {
        foreach (ICommand command in reverseBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1f);
        }
    }
    //    foreach (var command in Enumerable.Reverse(_commandBuffer))
    //    {
    //        command.Undo();
    //        yield return new WaitForSeconds(1);
    //    }
    //}



    public void DoneClicking()
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (var cube in cubes)
        { 
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        _commandBuffer.Clear();
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach (var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }      
    }

    private void Awake()
    {
        _instance = this;
    }

    //create a method to "add" commands to the command buffer

    //create a play routine triggered by a play method
    //that's going to play back all the commands
    //1 sec delay

    //create a rewind routine triggered by a rewind method t
    //hat's going to play in reverse
    //1 sec delay

    //done = finished with changing colors. turn them all white.

    //reset - clear the command buffer. -done
}
