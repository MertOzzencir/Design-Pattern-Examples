using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongEnemyFactory : EnemyFactory
{
    [SerializeField] private StrongEnemy strongEnemyPrefab;
    public override IEnemy CreateEnemy(Vector3 pos)
    {
        GameObject instance = Instantiate(strongEnemyPrefab.gameObject,pos,Quaternion.identity);
        StrongEnemy newStrongEnemy = instance.GetComponent<StrongEnemy>();
        return newStrongEnemy;
    }
}
