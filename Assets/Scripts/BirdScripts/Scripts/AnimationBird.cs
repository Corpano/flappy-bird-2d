using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBird : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator birdAnim;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        birdAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.y > .2f)
        {
            birdAnim.SetBool("Flying",true);
        }
        else
        {
            birdAnim.SetBool("Flying",false);
        }
    }
}
