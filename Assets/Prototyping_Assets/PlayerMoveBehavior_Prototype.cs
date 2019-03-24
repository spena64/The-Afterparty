using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveBehavior_Prototype : MonoBehaviour
{
    public int playerSpeed = 10;
    public int playerJump = 1250;
    public float xMove;
    public bool isAirborn; 

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
        if(Input.GetKeyDown(KeyCode.UpArrow) && isAirborn == false)
        {
            Jump();
            isAirborn = true;
        }
        // animation (maybe)

        // active side (later)


        // physics 
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMove * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJump);
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Floor")
        {
            isAirborn = false; 
        }
    }
}
