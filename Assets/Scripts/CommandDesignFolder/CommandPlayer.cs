using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandPlayer : MonoBehaviour
{
    [SerializeField] private Cube cube;
    MoveController invoker;
    void Start()
    {
        invoker = new MoveController();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ICommand newCommand = new MoveCommand(cube);
            invoker.AddCommand(newCommand);
        }
        if(Input.GetKey(KeyCode.F)){
            invoker.UndoCommand();
        }
    }
}
