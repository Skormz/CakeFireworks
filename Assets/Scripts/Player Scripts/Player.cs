using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask detectPlatforms;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    public float autoMovementSpeed = 5f;
    public float runDelay = 3f;
    public Animator animator;
    public float jumpPower = 10f;
    public float movementSpeed = 40f;
    
    bool facingRight = true;
    bool canRun = false;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if(runDelay >= 0)
        {
            runDelay -= Time.deltaTime;
        }

        else
        {
            canRun = true;
            Debug.Log("Can Run");
        }

        if (IsGrounded() && canRun == true && Input.GetKeyDown(KeyCode.Space))
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
        if (Input.GetKey(KeyCode.LeftArrow) && canRun == true)
        {
            rigidbody2d.velocity = new Vector2(-movementSpeed, rigidbody2d.velocity.y);
            animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
            if (facingRight)
                Flip();
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow) && canRun == true)
            {
                rigidbody2d.velocity = new Vector2(+movementSpeed, rigidbody2d.velocity.y);
                animator.SetFloat("Speed", Mathf.Abs(movementSpeed));
                if (!facingRight)
                    Flip();
            }
            else if(canRun == true)
            {
                rigidbody2d.velocity = new Vector2(autoMovementSpeed, rigidbody2d.velocity.y);
                animator.SetFloat("Speed", 1f);
                if (!facingRight)
                    Flip();
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
