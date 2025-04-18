using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIObserver : MonoBehaviour,IObserver
{
    [SerializeField] private Subject player;
    public void OnNotified()
    {
        Debug.Log("UI Updated");
    }

    void OnEnable()
    {
        player.AddObserver(this);
    }

    void OnDisable()
    {
        
        player.RemoveObserver(this);
    }


}
