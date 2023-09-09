using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        //Position:
        Vector3 spawnPosition = new Vector3(0, 3, 3);
        Instantiate(enemyPrefab, spawnPosition, enemyPrefab.transform.rotation);
    }
}
