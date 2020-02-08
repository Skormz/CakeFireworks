using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask detectPlatforms;
    private Rigidbody2D rigidbody2d;
    private BoxCollider2D boxCollider2d;

    public float jumpPower = 10f;
    public float movementSpeed = 40f;
    public KeyCode left;
    public KeyCode right;

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
        }
    }

    private bool IsGrounded() //Stops player from mid-air jumping, needs correct layers to work
    {
        RaycastHit2D raycastHit2d = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, .1f, detectPlatforms);
        Debug.Log(raycastHit2d.collider);
        return raycastHit2d.collider != null;
    }
}
