using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this saw death script this script allows me to be able to,
* set the speed of the bird. Then i can also set the different spots that 
* the bird can go to thus with the spin time i can set how long the weapon
* waits this allows the player to have time to avoid the bird.
*/
public class BirdAttack : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform RespawnPoint;
    public float BirdSpeed; //Enemy set speed.
    private float BirdRest;
    public float BirdSetOff;
    public Transform[] BirdScan; //Arrey created to add in the spots for patrol. 
    private int BirdSlice; // The int needed to have the patrol random.
    public AudioSource ScreamingBird;
    public AudioSource death;


    void Start()
    {
        BirdRest = BirdSetOff;
        BirdSlice = Random.Range(0, BirdScan.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, BirdScan[BirdSlice].position, BirdSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, BirdScan[BirdSlice].position) < 0.2f)
        {
            if (BirdRest <= 0)
            {
                BirdSlice = Random.Range(0, BirdScan.Length);
                BirdRest = BirdSetOff;
                ScreamingBird.Play();
            }
            else
            {

                BirdRest -= Time.deltaTime;

            }
        }
    }

        void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;
        death.Play();
    }

}