using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask detectPlatforms;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;
    public Animator animator;

    public float jumpPower = 10f;
    public float movementSpeed = 40f;
    public float autoMovementSpeed = 0f;
    bool facingRight = true;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpPower;
            animator.SetTrigger("Jump");
        }

        if (IsGrounded() == false)
            animator.SetBool("Airborn",true);
        else
            animator.SetBool("Airborn",false);


        HandleMovement();
    }

    private bool IsGrounded() //Stops player from mid-air jumping, needs correct layers to work
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, detectPlatforms);
        //Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }

    private void HandleMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2d.velocity = new Vector2(-movementSpeed, rigidbody2d.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
            if (facingRight)
                Flip();
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidbody2d.velocity = new Vector2(+movementSpeed, rigidbody2d.velocity.y);
                animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
                if (!facingRight)
                    Flip();
            }
            else
            {
                rigidbody2d.velocity = new Vector2(autoMovementSpeed, rigidbody2d.velocity.y);
                animator.SetFloat("Speed", 0f);
            }
        }
    }

    public void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
