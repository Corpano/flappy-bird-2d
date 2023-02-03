using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    // Pipes gameobject we are going to spawn in scene
    public GameObject pipesPrefab;
    // Minimum random Y position of pipe
    public float minY;
    // Maximum random Y position of pipe
    public float maxY;
    // First pipe's X position
    public float startX;
    // Distance between two nearby pipes
    public float distanceBetweenPipes;

    // Latest pipe we spawned
    GameObject lastSpawnedPipe;

    private void Start()
    {
        // Spawns first pipe
        SpawnNextPipe();
    }

    private void Update()
    {
        if(lastSpawnedPipe != null)
        {
            // Check if last spawned pipe's x position is within the range where we need to spawn next pipe
            if(lastSpawnedPipe.transform.position.x < 10f)
            {
                SpawnNextPipe();
            }
        }
        else
        {
            Debug.LogError("First pipe has not been spawned yet.");
        }
    }

    // Spawn next pipe
    void SpawnNextPipe()
    {
        // Pipe's x position
        float currentX;

        // If we spawned pipes before
        if(lastSpawnedPipe != null)
        {
            // Make distance between last pipe we spawned and new pipe
            currentX = lastSpawnedPipe.transform.position.x + distanceBetweenPipes;
        }
        else
        {
            // This is our first pipe, spawn it at startX position
            currentX = startX;
        }

        // Spawn two pipes
        lastSpawnedPipe = Instantiate(pipesPrefab, transform);

        // Randomize y position of pipe
        float randomY = Random.Range(minY, maxY);
        lastSpawnedPipe.transform.position = new Vector2(currentX, randomY);
    }
}