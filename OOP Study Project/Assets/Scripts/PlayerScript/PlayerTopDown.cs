using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SkagoGames.PlayerNC;

public class PlayerTopDown : PlayerBehaviour
{
    public float moveSpeed = 5f;

    protected override void VPlayerLoop()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector2 movement = transform.right * x + transform.up * y;
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
