using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdTrigger : MonoBehaviour
{
    // Sound for bird when it gets a point
    public AudioSource scoreSoundEffect;
    // Sound for when the bird hits pipe/ground
    public AudioSource hitSoundEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // If we lost, don't do nothing
        if (GameManager.didLose)
            return;

        // If bird hits the pipe/ground
        if (other.CompareTag("Fail"))
        {
            // Rotate it downwards
            transform.eulerAngles = Vector3.forward * -50f;
            // Hit sound effect
            hitSoundEffect.Play();
            // Lose
            FindObjectOfType<GameManager>().Lose();
        }
        // Bird should get a point
        else if (other.CompareTag("Success"))
        {
            // Score sound effect
            scoreSoundEffect.Play();
        }
    }
}
