using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBottom : MonoBehaviour
{
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyFollow.activeSide == 'b')
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
        if (col.gameObject.tag == "Player")
        {
            if (isActive)
            {
                Debug.Log("Player hit Active Side: Bottom");
                EnemyHealth_Prototype.health--;
            }
        }
    }
}
