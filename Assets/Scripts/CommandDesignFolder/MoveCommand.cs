using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Cube cube;
    Vector3 currentDestination;

    public MoveCommand(Cube cube){
        this.cube = cube;
        currentDestination = cube.transform.position;
    }
    public void Execute()
    {
        cube.SetPosition(cube.transform.position + Vector3.back);
    }

    public void Undo()
    {
        cube.SetPosition(currentDestination);
    }

   
}
