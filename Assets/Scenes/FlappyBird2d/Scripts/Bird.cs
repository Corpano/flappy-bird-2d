using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rb;
    private float playerVerticalVel = 0;
    private float playerHorizontalVel = 0;
    private float movementSpeed = 5;
    private float flyingForce = 0;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        this.rb.velocity = new Vector2(movementSpeed,10);
    }


    // Update is called once per frame
    void Update()
    {
        playerHorizontalVel = this.rb.velocity.x;
        playerVerticalVel= this.rb.velocity.y;

        if(Input.GetMouseButtonDown(0))
        {
            flyingForce = 20;
        }
    }

    void FixedUpdate()
    {
        this.rb.AddForce(new Vector2(0,flyingForce),ForceMode2D.Impulse);
        flyingForce = 0;
        if(this.rb.velocity.y > 10)
            this.rb.velocity = new Vector2(movementSpeed,10);
        if(this.rb.velocity.y < -10)
            this.rb.velocity = new Vector2(movementSpeed,-10);

    }
}
