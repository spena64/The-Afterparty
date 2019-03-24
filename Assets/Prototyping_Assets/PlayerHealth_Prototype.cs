using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 1;
    public bool dead = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            dead = true; 
            Die(); 
        }
    }

    void Die()
    {
        // probably set it to do something when it dies

    
    }
}
