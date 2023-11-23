using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, world!");
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 20;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -10;
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement.x = -10;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement.x += 10;
        }

        rb.velocity = movement;

    }
}
