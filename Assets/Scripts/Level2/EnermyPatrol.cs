using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyPatrol : MonoBehaviour
{
    public float speed; //Enemy set speed.
    private float EnermyWaitTime;
    public float StartEnermyWaitTime;
    public Transform[] patrolSpots; //Array created to add in the spots for patrol. 
    private int randomPatrol; // The int needed to have the patrol random.

    void Start()
    {
        EnermyWaitTime = StartEnermyWaitTime;
        randomPatrol = Random.Range(0, patrolSpots.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolSpots[randomPatrol].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolSpots[randomPatrol].position) < 0.2f)
        {
            if (EnermyWaitTime <= 0)
            {
                randomPatrol = Random.Range(0, patrolSpots.Length);
                EnermyWaitTime = StartEnermyWaitTime;

            }
            else
            {

                EnermyWaitTime -= Time.deltaTime;

            }
        }
    }
}

