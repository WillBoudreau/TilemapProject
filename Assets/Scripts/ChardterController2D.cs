using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChardterController2D : MonoBehaviour
{
    [Header("Player Attributes")]
    public float moveSpeed = 5.0f;

    public Rigidbody2D rb;

    Vector2 movement;
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position +  movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
