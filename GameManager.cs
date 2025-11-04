using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject EnemySpherePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemySphere", 3, 5);
        InvokeRepeating("CreateEnemySinger", 6, 4);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

        void CreateEnemySphere()
    {
        Instantiate(EnemySpherePrefab, new Vector3(Random.Range(-8f, -1f), 9.5f, 0), Quaternion.identity);
    }

    void CreateEnemySinger()
    {
        Instantiate(EnemySingerPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

}
