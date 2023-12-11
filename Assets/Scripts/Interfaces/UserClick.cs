using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UserClick : MonoBehaviour
{
    CommandManager _commandManager;
    // Start is called before the first frame update
    void Start()
    {
        _commandManager = GameObject.Find("CommandManager").GetComponent<CommandManager>();
        if(_commandManager == null)
        {
            Debug.LogError("UserClick::CommandManager is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Cube"))
                {
                    ICommand click = new ClickCommand(hit.collider.gameObject, 
                        new Color(Random.value, Random.value, Random.value));

                    click.Execute();
                   _commandManager.AddClick(click);
                }
            }
        }    
    }


}
