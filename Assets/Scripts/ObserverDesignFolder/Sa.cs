using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sa : MonoBehaviour,IObserver
{
    [SerializeField] private Subject player;
    public void OnNotified()
    {
        Debug.Log("Sa");
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
