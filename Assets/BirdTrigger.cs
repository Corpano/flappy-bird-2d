using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdTrigger : MonoBehaviour
{
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
            // Lose
            FindObjectOfType<GameManager>().Lose();
        }
        // Bird should get a point
        else if (other.CompareTag("Success"))
        {
            FindObjectOfType<GameManager>().OnScore();
            Destroy(other.gameObject);
        }
    }
}
