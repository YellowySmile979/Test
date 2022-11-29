using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float jumpSpeed = 7;

    public Transform groundCheck;
    private float groundCheckRadius = 0.21f;
    public LayerMask whatIsGround;

    Rigidbody2D rb;
    Animator anim;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("moveSpeed", Mathf.Abs(rb.velocity.x));

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);

        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);

        }else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);

        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity += new Vector2(0, jumpSpeed);

        }
    }
}
