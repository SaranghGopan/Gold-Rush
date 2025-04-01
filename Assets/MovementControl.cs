using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    public float jumpForce;
    public bool moveLeft, moveRight;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveLeft = false;
        moveRight = false;
        animator.SetTrigger("Idle");

    }

    // Update is called once per frame
    void Update()
    {
        CheckKeyboardInput();

        if (moveLeft)
        {
          rb.linearVelocity = new Vector2(-moveSpeed, 0);
            animator.SetTrigger("Run");
        }
        if (moveRight)
        {
            rb.linearVelocity = new Vector2(moveSpeed, 0);
            animator.SetTrigger("Run");
        }

    }
    public void MoveLeftAction()
    {
        moveLeft = true;
    }
    public void MoveRightAction()
    {
        moveRight = true;
    }
    public void MoveStop()
    {
        moveLeft = false;
        moveRight = false;
        rb.linearVelocity = new Vector2(0, 0);
        animator.SetTrigger("Idle");
    }
    public void JumpAction()
    {
        if (rb.linearVelocity == Vector2.zero)
        {
            rb.AddForce(Vector2.up * jumpForce);
            animator.SetTrigger("Jump");
        }
    }
    public void CheckKeyboardInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MoveStop();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRight = true;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            MoveStop();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAction();
        }
    }
}
