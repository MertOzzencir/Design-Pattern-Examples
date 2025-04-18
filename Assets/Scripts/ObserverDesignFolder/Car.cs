using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Subject
{
  
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            Debug.Log("Notified in Car");
            OnNotify();
        }
    }
}
