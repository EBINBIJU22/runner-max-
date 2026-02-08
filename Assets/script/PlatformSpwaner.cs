using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;    // Assign platform prefab
    public Transform spawnPoint;         // Where platforms appear
    public float spawnInterval = 2f;     // Time between spawns

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 15f, spawnInterval);
    }

    void SpawnPlatform()
    {
        Instantiate(platformPrefab, spawnPoint.position, Quaternion.identity);
    }
}