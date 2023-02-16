using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Did we lose?
    public static bool didLose = false;

    // Sound for bird when it gets a point
    public AudioSource scoreSoundEffect;
    // Sound for when the bird hits pipe/ground
    public AudioSource hitSoundEffect;

    public TextMeshProUGUI pointsTxt;

    public int PointsCount = 0;

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

        // Hit sound effect
        hitSoundEffect.Play();

        // Stop moving environment
        PipeMover.isMoving = false;
        GroundMover.isMoving = false;
        EnvironmentMover.isMoving = false;
    }

    public void OnScore()
    {
        // Score sound effect
        scoreSoundEffect.Play();
        
        PointsCount++;
        pointsTxt.text = PointsCount.ToString("00");
    }
}
