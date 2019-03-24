using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTop : MonoBehaviour
{
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyFollow.activeSide == 't')
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
                Debug.Log("Player hit Active Side: Top");
                EnemyHealth_Prototype.health--;
            }
        }
    }
}
