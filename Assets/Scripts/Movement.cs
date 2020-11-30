using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Variables

    Rigidbody2D PlayerRb;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    bool isGrounded = false;
    [SerializeField] Transform isGroundedChecker;
    [SerializeField] float checkGroundRadius;
    [SerializeField] LayerMask groundLayer;

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
        if(Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpForce);
        }
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        isGrounded = collider != null ? true : false;
        //if (collider !=null){isGrounded = true;}
        //else{isGrounded = false;}
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
