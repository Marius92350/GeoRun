using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    public float jumpForce = 1;

    bool isJumping;

    bool isGrounded;

    public float speed = 3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && isGrounded)
        {
            isJumping = true;
        }
        
    }

    private void FixedUpdate()
    {
        if(isJumping)
        {
            Jump();
            isJumping = false;
        }

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
