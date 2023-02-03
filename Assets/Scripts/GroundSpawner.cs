using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    // Ground block prefab
    public GameObject groundPrefab;
    // Y position of the ground
    public float yPosition;
    // X offset / distance between two ground objects
    public float xOffset;

    // Latest ground object spawned
    GameObject lastSpawnedGround;

    private void Start()
    {
        // Spawn first ground
        SpawnNextGround();
    }

    private void Update()
    {
        if(lastSpawnedGround != null)
        {
            // Check if it's time to spawn next ground object
            if(lastSpawnedGround.transform.position.x < 10f)
            {
                // Spawn new ground
                SpawnNextGround();
            }
        }
        else
        {
            Debug.LogError("First ground has not been spawned yet.");
        }
    }

    void SpawnNextGround()
    {
        // Grounds X position
        float currentX;
        if (lastSpawnedGround != null)
        {
            // Add X offset - keep distance between grounds
            currentX = lastSpawnedGround.transform.position.x + xOffset;
        }
        else
        {
            // First ground's X position
            currentX = 0f;
        }

        // Spawn ground object
        lastSpawnedGround = Instantiate(groundPrefab, transform);

        // Set it's position
        lastSpawnedGround.transform.position = new Vector2(currentX, yPosition);
    }
}
