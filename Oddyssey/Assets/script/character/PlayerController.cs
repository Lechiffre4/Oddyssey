using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true; 
    Rigidbody2D playerRB; 
    SpriteRenderer playerRenderer; 
    bool facingRight = true; 
    public float maxSpeed;
    Animator playerAnim;


    //Variable de saut
    bool grounded = false; 
    float groundCheckRadius = 0.2f; 
    public LayerMask groundLayer;
    public LayerMask boxLayer;
    public Transform groundCheck; 
    public float jumpPower;





    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
        playerAnim = GetComponent<Animator>(); 
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        float move = Input.GetAxis("Horizontal");


        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();


        //Jump&Move

        if (grounded && Input.GetAxis("Jump") > 0 && canMove)
        { 
            playerAnim.SetBool("IsGrounded", false); 
            playerRB.velocity = new Vector2(playerRB.velocity.x, 0f); 
            playerRB.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse); 
            playerAnim.SetFloat("VerticalVelocity", playerRB.velocity.y);
            grounded = false; 


        }

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer) || Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, boxLayer);

        playerAnim.SetBool("IsGrounded", grounded); 

        if (canMove)
        {
            playerRB.velocity = new Vector2(move * maxSpeed, playerRB.velocity.y); 
            playerAnim.SetFloat("MoveSpeed", Mathf.Abs(move));
        }
        else
        {
            playerRB.velocity = new Vector2(0, playerRB.velocity.y); 
            playerAnim.SetFloat("MoveSpeed", 0); 
        }


       

    }


    void Flip()
    {
        facingRight = !facingRight; 
        playerRenderer.flipX = !playerRenderer.flipX; 
    }


    public void toggleCanMove()
    {
        canMove = !canMove;
    }


  
}

