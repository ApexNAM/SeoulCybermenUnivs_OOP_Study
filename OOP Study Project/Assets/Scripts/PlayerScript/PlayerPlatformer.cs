using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkagoGames.PlayerNC;

public class PlayerPlatformer : PlayerBehaviour
{
    public Rigidbody2D rigidbody2Ds;
    public float moveSpeed = 5f;
    public Transform groundPos;
    public LayerMask whatisGround;

    private float groundDistance = 0.4f;
    private bool isGrounded = false;
    protected override void VPlayerSetup()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rigidbody2Ds = GetComponent<Rigidbody2D>();
    }

    protected override void VPlayerLoop()
    {
        float moveRight = Input.GetAxisRaw("Horizontal");
        Vector2 movement = transform.right * moveRight;

        transform.Translate(movement * moveSpeed * Time.deltaTime);
        
        isGrounded = Physics2D.OverlapCircle(groundPos.position, groundDistance, whatisGround);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            rigidbody2Ds.AddForce(Vector2.up * 7f, ForceMode2D.Impulse);
        }
    }

    protected override void OnPlayerEnter2D(Collider2D otherP2D)
    {
        if(otherP2D.gameObject.tag == "Enemy")
        {
            Debug.Log("맞았다!");
        }
    }
}
