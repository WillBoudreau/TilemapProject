using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChardterController2D : MonoBehaviour
{
    [Header("Player Attributes")]
    [SerializeField] float moveSpeed = 5.0f;

    [SerializeField] Rigidbody2D rb;
    [SerializeField] private Animator _anim;
    private float x;
    private float y;

    Vector2 movement;
    void Update()
    {
        _anim.GetComponent<Animation>();
        rb = GetComponent<Rigidbody2D>();
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        x = movement.x;
        y = movement.y;
    }
    void FixedUpdate()
    {
        PlayerMove();
        PlayerAnimaiton();
    }
    //Moves Player
   public void PlayerMove()
    {
        //Moves player based off of rigidbody
        rb.MovePosition(rb.position +  movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
    //Plays animation
    public void PlayerAnimaiton()
    {
        _anim.SetFloat("POSX",x);
        _anim.SetFloat("POSY",y);

        if(movement != Vector2.zero)
        {
            _anim.SetBool("PlayerPOSMove",true);
        }
        else
        {
            _anim.SetBool("PlayerPOSMove",false);
        }
    }
}