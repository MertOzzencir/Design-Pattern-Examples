using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private List<IObserver> observers= new List<IObserver>();
    public void AddObserver(IObserver observer){

        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer){
        observers.Remove(observer);
    }

    public void OnNotify(){
        foreach(IObserver observer in observers){
            observer.OnNotified();
            Debug.Log(observer);
        }
    }
    
}
