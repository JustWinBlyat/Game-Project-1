using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField]
    private GameObject coinPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe to the OnCoinCollected event
        CollectCoin.OnCoinCollected += SpawnNewCoin;

        // Spawn the initial coin
        SpawnNewCoin();
    }

    void SpawnNewCoin()
    {
        // Position:
        Vector3 spawnPosition = new Vector3(Random.Range(-3, 3), 0.2f, Random.Range(-3, 3));
        Instantiate(coinPrefab, spawnPosition, coinPrefab.transform.rotation);
    }


    // Unsubscribe from the OnCoinCollected event when this GameObject is destroyed
    void OnDestroy()
    {
        CollectCoin.OnCoinCollected -= SpawnNewCoin;
    }
}
