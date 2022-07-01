using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed;
    public float direction;
    public float jumpForce;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Jump();
    }
    
    void Move (){
        direction = Input.GetAxis("Horizontal");
        if(direction > 0 || direction < 0)
            rb.velocity = new Vector2 (direction * speed, rb.velocity.y);
    }
    void Jump(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Jump!");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

}
