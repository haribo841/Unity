using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private int wholeNumber = 0;
    private float decimalNumber = 21.37f;
    private string text = "Hello, world!";
    private bool boolean = false;
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(text);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX*5f, rb.velocity.y);
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 10f);
        }

    }
}
