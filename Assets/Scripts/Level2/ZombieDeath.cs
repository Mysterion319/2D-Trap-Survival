using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this zombie death script this script allows me to be able to,
* set the speed of the zombie. Then I can also set the different spots that 
* the saw can go to thus with the spin time I can set how long the weapon
* waits this allows the player to have time to avoid the zombie.
*/
public class ZombieDeath : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform RespawnPoint;
    public AudioSource death;
    public float ZombieSpeed; //Enemy set speed.
    private float ZombieWait;
    public float ZombieStallTime;
    public Transform[] patrolSpots; //Array created to add in the spots for patrol. 
    private int randomPatrol; // The int needed to have the patrol random.

    void Start()
    {
        ZombieWait = ZombieStallTime;
        randomPatrol = Random.Range(0, patrolSpots.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolSpots[randomPatrol].position, ZombieSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolSpots[randomPatrol].position) < 0.2f)
        {
            if (ZombieWait <= 0)
            {
                randomPatrol = Random.Range(0, patrolSpots.Length);
                ZombieWait = ZombieStallTime;

            }
            else
            {

                ZombieWait -= Time.deltaTime;

            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;
        death.Play();
    }

}
