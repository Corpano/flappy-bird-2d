using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    // Speed at which environment moves
    private float movingSpeed = 3.0f;

    private const double BACKGROUND_LENGTH = 27.7;
    private const double BACKGROUND_PAST_CAMERA = -12.8;

    bool isMoving = true;

    private void Update()
    {
        // If environment is moving (game isn't over yet)
        if (isMoving)
        {
            // Move environment to the left
            transform.position += Vector3.left * Time.deltaTime * movingSpeed;
        }

        // Creates an infinte loop with background
        if (transform.position.x <= BACKGROUND_PAST_CAMERA)
        {
            // Brings background that has gone passed the camera view to the front
            Destroy(this.gameObject);
        }
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}
