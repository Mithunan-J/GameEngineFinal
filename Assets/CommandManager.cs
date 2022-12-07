using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public static CommandManager commandManager;
    public List<ICommand> commandList = new List<ICommand>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if(commandManager != null && commandManager != this)
        {
            Destroy(this);
        }
        else
        {
            commandManager = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddCommand(ICommand command)
    {
        commandList.Add(command);
    }

    public void Reverse()
    {
        for(int i = commandList.Count-1; i > commandList.Count-7; i--)
        {
            commandList[i].Undo();
        }
    }
}
