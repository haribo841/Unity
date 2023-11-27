using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private float decimalNumber = 21.37f;
    private string text = "Hello, world!";
    private bool boolean = false;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(text);
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        bool space = Input.GetKey(KeyCode.Space);
        rb.velocity = new Vector2(dirX*5f, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
            animator.SetBool("jumping", true);
        }
        if (dirX > 0f)
        {
            animator.SetBool("running", true);
        }
        else if (dirX < 0f)
        {
            animator.SetBool("running", true);
        }
        else
        {
            animator.SetBool("running", false);
        }
        if (space)
        {
            
        }
        else
        {
            animator.SetBool("jumping", false);
        }
    }
}
