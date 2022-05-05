using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 movementInput;
    Rigidbody2D rb;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>(); //raycast checks if a move is valid before making the move
    Animator animator;

    public float moveSpeed = 1f;
    public ContactFilter2D movementFilter;
    public float collisionOffset = 0.05f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        if (movementInput != Vector2.zero)
        {
            int count = rb.Cast(
                movementInput, // x and y values between -1 and 1 that represent the direction from the body to look for collisions
                movementFilter, // the settings that determine where a collision can occur on such as layers to collide with
                castCollisions, // list of collisions to store the found collisions in to after the Cast is finished
                moveSpeed * Time.fixedDeltaTime + collisionOffset); // the amount to cast equal to the movement plus an offset
            if (count == 0)
            {
                rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
                Debug.Log(movementInput * moveSpeed * Time.fixedDeltaTime);
            }
        }
        if (rb.velocity.magnitude > 0){
            animator.SetBool("isMoving", true);
        }
        else{
            animator.SetBool("isMoving", false);
        }
    }

    void OnMove(InputValue movementValue)
    {
        movementInput = movementValue.Get<Vector2>();
    }
    
}
