using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemy : MonoBehaviour, IEnemy
{
    void Update()
    {
        transform.position +=Vector3.right;
    }
    public void Attack()
    {
        Debug.Log("Attacking to Player Strongly");
    }
}
