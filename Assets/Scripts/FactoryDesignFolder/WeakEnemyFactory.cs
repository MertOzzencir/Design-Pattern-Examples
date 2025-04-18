using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakEnemyFactory : EnemyFactory
{
    [SerializeField] private WeakEnemy weakEnemyPrefab;
    public override IEnemy CreateEnemy(Vector3 pos)
    {
        GameObject instance = Instantiate(weakEnemyPrefab.gameObject,pos,Quaternion.identity);
        IEnemy newStrongEnemy = instance.GetComponent<WeakEnemy>();
        return newStrongEnemy;
    }
}
