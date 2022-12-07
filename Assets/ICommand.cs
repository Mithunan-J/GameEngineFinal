using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    public void Execute(GameObject _object);

    public void Undo();
}
