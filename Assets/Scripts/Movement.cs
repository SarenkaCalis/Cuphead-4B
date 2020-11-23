using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Variables

    public Rigidbody2D PlayerRb;
    public float speed;
    public float jumpForce;
    public bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;

    #endregion

    #region Functions

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        PlayerRb.velocity = new Vector2(moveBy, PlayerRb.velocity.y);
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpForce);
        }
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if(collider !=null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    #endregion

    void Start()
    {   
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();
    }
}
