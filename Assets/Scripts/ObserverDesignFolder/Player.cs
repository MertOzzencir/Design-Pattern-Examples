using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject
{
  
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Notified in Player");
        }
    }
}
