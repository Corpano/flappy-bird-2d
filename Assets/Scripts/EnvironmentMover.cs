using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentMover : MonoBehaviour
{
    // Speed at which environment moves
    private float movingSpeed = .7f;

    private const double BACKGROUND_LENGTH = 27.7;
    private const double BACKGROUND_PAST_CAMERA = -12.8;

    public static bool isMoving = true;

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
            transform.position += new Vector3((float)BACKGROUND_LENGTH,0,0);
        }
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}
