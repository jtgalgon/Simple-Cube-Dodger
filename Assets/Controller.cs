using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float jumpSpeed;
    private float moveHorizontal;
    private float moveVertical;
    public Vector3 originalPos;
    public bool isGrounded;
    public float test;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        test = rb.velocity.x;
        jumpSpeed = 10F;
    }
    private void OnCollisionEnter(Collision other) {
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate(){
        test = rb.velocity.x;
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        //jumping
        if(Input.GetButtonDown("Jump") && isGrounded == true){
            isGrounded = false;
            Vector3 jump = new Vector3(0,5,0);
            rb.AddForce(jump * jumpSpeed);
        }
        //falling
        if(rb.velocity.y < 0){
            Vector3 fall = new Vector3(0,Physics2D.gravity.y, 0);
            rb.AddForce(fall);
        }
        //movement
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.AddForce(movement * speed * Time.deltaTime);
    }
}
