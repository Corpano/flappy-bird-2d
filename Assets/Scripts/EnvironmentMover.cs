using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMover : MonoBehaviour
{
    // Speed at which environment moves
    public float movingSpeed = 1.5f;

    bool isMoving = true;

    private void Update()
    {
        // If environment is moving (game isn't over yet)
        if (isMoving)
        {
            // Move environment to the left
            transform.position += Vector3.left * Time.deltaTime * movingSpeed;
        }
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}
