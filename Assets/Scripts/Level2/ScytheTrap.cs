using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheTrap : MonoBehaviour
{
    public float speed; //Enemy set speed.
    private float ScytheWaitTime;
    public float CountDownToScythe;
    public Transform[] patrolSpots; //Arrey created to add in the spots for patrol. 
    private int randomPatrol; // The int needed to have the patrol random.

    void Start()
    {
        ScytheWaitTime = CountDownToScythe;
        randomPatrol = Random.Range(0, patrolSpots.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolSpots[randomPatrol].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolSpots[randomPatrol].position) < 0.2f)
        {
            if (ScytheWaitTime <= 0)
            {
                randomPatrol = Random.Range(0, patrolSpots.Length);
                ScytheWaitTime = CountDownToScythe;

            }
            else
            {

                ScytheWaitTime -= Time.deltaTime;

            }
        }
    }
}
