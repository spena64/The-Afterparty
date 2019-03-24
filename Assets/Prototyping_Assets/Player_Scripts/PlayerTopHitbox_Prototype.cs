using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopHitbox_Prototype : MonoBehaviour
{
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMoveBehavior_Prototype.activeSide == 't')
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            if (isActive)
            {
                Debug.Log("Enemy hit Active Side: Top");
                PlayerHealth_Prototype.health--;
            }
        }
    }
}
