using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 2f;
    

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        int randomPoint = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomPoint];

        int randomPrefab = Random.Range(0, coinPrefabs.Length);
        Instantiate(coinPrefabs[randomPrefab], spawnPoint.position, Quaternion.identity);
    }

}