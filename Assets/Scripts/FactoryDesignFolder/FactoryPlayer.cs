using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPlayer : MonoBehaviour
{
    [SerializeField] private List<EnemyFactory> listOfEnemyType;
    private List<IEnemy> spawnedEnemy;

    void Start()
    {
        spawnedEnemy = new List<IEnemy>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            int randomIndexOfEnemyType = Random.Range(0,listOfEnemyType.Count);
            IEnemy newEnemy = listOfEnemyType[randomIndexOfEnemyType].CreateEnemy(Vector3.zero);
            spawnedEnemy.Add(newEnemy);
            newEnemy.Attack();

        } 
        if(Input.GetKeyDown(KeyCode.KeypadEnter)){
            foreach(IEnemy enemy in spawnedEnemy){
                Debug.Log(enemy);
            }
        }
    }
}
