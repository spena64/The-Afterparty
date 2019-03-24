using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehavior_Prototype : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool isRightFacing = true;
    public int playerJump = 1250;
    public float xMove; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }

    void MovePlayer()
    {
        // controls
        xMove = Input.GetAxis("Horizontal");

        // animation 

        // direction 
        if (xMove < 0.0f && isRightFacing == false)
        {
            FlipPlayer(); 
        }
        else if (xMove > 0.0f && isRightFacing == false)
        {
            FlipPlayer(); 
        }

        // physics 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMove * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);

    }

    void Jump()
    {

    }

    void FlipPlayer()
    {
        
    }
}
