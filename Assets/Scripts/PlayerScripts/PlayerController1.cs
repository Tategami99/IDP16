using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;
    private float moveX;
    private float moveY;

    Animator animator;

    // Update is called once per frame

    private void Start() {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ProcessInputs();
        //processing inputs
    }

    void FixedUpdate(){
        Move();

        
        //physics calculations
    }

    void ProcessInputs(){
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move(){
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
  
}
