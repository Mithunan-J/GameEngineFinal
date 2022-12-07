using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    // Start is called before the first frame update
    public bool pelletActive = true;
    PelletEatenCommand newCommand;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        ICommand pelletCommand = new PelletEatenCommand();
        
        pelletCommand.Execute(this.gameObject);

        //CommandManager.commandManager.AddCommand(newCommand);
    }

    public void PelletEaten()
    {
        this.gameObject.SetActive(!pelletActive);
    }

}
