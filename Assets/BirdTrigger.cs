using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdTrigger : MonoBehaviour
{

    public Animator anim; //Animator for the GameOver sign

    public GameObject restartTrigger; //Restarts the game

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
            // Game Over Animation
            anim.SetBool("isDead",true);

            restartTrigger.SetActive(true);
        }
        // Bird should get a point
        else if (other.CompareTag("Success"))
        {
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().OnScore();
        }
    }
}
