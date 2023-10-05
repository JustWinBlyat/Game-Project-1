using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; // Reference to the Coin prefab
    public float spawnInterval = 5.0f; // Time interval for spawning coins
    public float xRange = 3.0f; // Range for spawning on the X-axis
    public float zRange = 3.0f; // Range for spawning on the Z-axis
    public float yPosition = 0.2f; // Y-axis position where the coin will be spawned

    // Start is called before the first frame update
    void Start()
    {
        // Print a debug message to confirm the Start method is invoked
        Debug.Log("CoinSpawner started.");

        StartCoroutine(SpawnCoins());
    }

    // Coroutine to spawn coins
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            // Generate random positions within the specified range
            float xPos = Random.Range(-xRange, xRange);
            float zPos = Random.Range(-zRange, zRange);

            // Print a debug message to show the generated positions
            Debug.Log($"Attempting to spawn coin at ({xPos}, {yPosition}, {zPos}).");

            // Instantiate a new coin at the random position
            Instantiate(coinPrefab, new Vector3(xPos, yPosition, zPos), Quaternion.identity);

            // Wait for the next spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
