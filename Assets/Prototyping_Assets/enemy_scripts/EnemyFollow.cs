using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public static char activeSide;
    public float speed;
    private Transform target;

    //private float nextActionTime = 10f;
    //public float period = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        activeSide = 'r';
        if (activeSide == 'r')
        {
            Debug.Log("E Active side set to Top");
        }

        InvokeRepeating("SetActiveSide", 2.0f, 5.0f);
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        /*
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            SetActiveSide();
        }
        */

    }

    void SetActiveSide()
    {
        int rand = UnityEngine.Random.Range(1, 4);

        if (rand == 1)
        {
            activeSide = 't';
            Debug.Log("E Active side set to Top");
        }
        else if (rand == 2)
        {
            activeSide = 'l';
            Debug.Log("E Active side set to Left");
        }
        else if (rand == 3)
        {
            activeSide = 'b';
            Debug.Log("E Active side set to Bottom");
        }
        else if (rand == 4)
        {
            activeSide = 'r';
            Debug.Log("E Active side set to Right");
        }
    }
}
