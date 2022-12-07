using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletEatenCommand : ICommand
{
    public PelletEatenCommand _command;
    public PelletEatenCommand()
    {
        
    }
    public GameObject _pelletObj;
   public void Execute(GameObject _pellet)
    {
        _pelletObj = _pellet;
        _pellet.GetComponent<Pellet>().PelletEaten();
        GameManager.instance.pelletsCollected += 1;
    }

    public void Undo()
    {
        _pelletObj.gameObject.SetActive(true);
    }
}
