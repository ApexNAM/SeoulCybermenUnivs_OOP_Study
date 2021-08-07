using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : PlayerBehaviour
{
    public Rigidbody2D rigidbody2Ds;
    public float moveSpeed = 5f;

    public override void IFPlayerSetup()
    {
        rigidbody2Ds = GetComponent<Rigidbody2D>();
    }

    public override void IFPlayerLoop()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = transform.right * x + transform.up * y;
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
