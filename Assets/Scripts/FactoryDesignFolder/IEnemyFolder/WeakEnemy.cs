using UnityEngine;
public class WeakEnemy : MonoBehaviour, IEnemy
{
     void Update()
    {
        transform.position +=Vector3.left;
    }
    public void Attack()
    {
        Debug.Log("Attacking to Player Weakly");
    }
}
