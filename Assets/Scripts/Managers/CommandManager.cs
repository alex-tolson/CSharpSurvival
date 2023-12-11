using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
        foreach (var command in _commandBuffer)
        {
            Invoke("command.Execute", 1);
        }
    }

    public void Rewind()
    {
        var reverseCommandbuffer = _commandBuffer.Reverse<ICommand>();
    }

    public void DoneClicking()
    {

    }
    public void Reset()
    {
        _commandBuffer.Clear();
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




    private void Awake()
    {
        _instance = this;
    }
}
