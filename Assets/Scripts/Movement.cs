using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Variables

    public Rigidbody2D PlayerRb;
    public float speed;
    public float jumpForce;

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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpForce);
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
    }
}
