using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Did we lose?
    public static bool didLose = false;

    private void Start()
    {
        didLose = false;

        // In beginning everything is moving
        PipeMover.isMoving = true;
        GroundMover.isMoving = true;
        EnvironmentMover.isMoving = true;
    }


    // On lose (when bird hits pipe/ground)
    public void Lose()
    {
        didLose = true;

        // Stop moving environment
        PipeMover.isMoving = false;
        GroundMover.isMoving = false;
        EnvironmentMover.isMoving = false;
    }
}
