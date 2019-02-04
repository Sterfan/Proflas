using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 7.0f;
    private Vector2 moveDirection;

  
    void Start()
    {
        
    }

    void Update()
    {
        GetInput();
        movement();
    }

    public void movement()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void GetInput()
    {
        moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector2.down;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector2.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector2.left;
        }
    }
}
