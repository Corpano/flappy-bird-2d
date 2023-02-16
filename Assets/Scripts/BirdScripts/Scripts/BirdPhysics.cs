using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPhysics : MonoBehaviour
{
    public AudioSource wingsFlapSoundEffect;

    private Rigidbody2D rb;
    private float playerVerticalVel = 0;
    private float playerHorizontalVel = 0;
    private float flyingForce = 0;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        this.rb.velocity = new Vector2(0,10);
    }


    // Update is called once per frame
    void Update()
    {
        playerHorizontalVel = this.rb.velocity.x;
        playerVerticalVel= this.rb.velocity.y;

        if(Input.GetMouseButtonDown(0) && !GameManager.didLose)
        {
            wingsFlapSoundEffect.Play();
            flyingForce = 20;
        }
    }

    void FixedUpdate()
    {
        this.rb.AddForce(new Vector2(0,flyingForce),ForceMode2D.Impulse);
        flyingForce = 0;
        if(this.rb.velocity.y > 8.8)
            this.rb.velocity = new Vector2(0,8.8f);
        if(this.rb.velocity.y < -8.8)
            this.rb.velocity = new Vector2(0,-8.8f);

    }
}

