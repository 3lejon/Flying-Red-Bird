using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Pipe Settings")]
    public GameObject pipePrefab;       // The pipe prefab to spawn
    public float spawnRate = 2f;        // Time between spawns
    public float minY = -14f;            // Minimum vertical position
    public float maxY = 16f;             // Maximum vertical position

    private float timer = 0f;

    void Update()
    {
        // Count up the timer
        timer += Time.deltaTime;

        // If enough time has passed, spawn a pipe
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        // Randomize vertical position
        float randomY = Random.Range(minY, maxY);

        // Spawn pipe at spawner's position with random Y offset
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
    }
}
