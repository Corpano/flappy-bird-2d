using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdRotation : MonoBehaviour
{
    private Quaternion playerRotate;
    private Rigidbody2D rb;
    private GameObject birdSprite;

    private float AngleFormula;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        birdSprite = this.gameObject.transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        AngleFormula = rb.velocity.y * 7;
        transform.rotation = Quaternion.Euler(0,0,AngleFormula);
    }

}
