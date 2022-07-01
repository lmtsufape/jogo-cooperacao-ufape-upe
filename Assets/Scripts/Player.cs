using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int speed;
    
    [SerializeField]
    private float jumpForce;

    private float direction;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
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


    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "EnvironmentTrigger" && Input.GetAxisRaw("Vertical") > 0){
            Debug.Log ("Tree");
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }  
    }

}
