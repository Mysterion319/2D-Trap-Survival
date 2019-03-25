using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleDeath : MonoBehaviour
{
    public float speed; //Enemy set speed.
    private float MissileStallTime;
    public float IgniteMissleTime;//Set the wait time for the missle.
    public Transform[] MissileTargets; //Arrey created to add in the spots for patrol. 
    private int RandomMissleAttack; // So the missle can attack randomly.
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform DeathRespwan;
    public AudioSource death;






    void Start()
    {
        MissileStallTime = IgniteMissleTime;//Says the the missile stall time will equal the ignite missle time.
        RandomMissleAttack = Random.Range(0, MissileTargets.Length);//This is the random missile attack randomly picking one of the missle targets.
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MissileTargets[RandomMissleAttack].position, speed * Time.deltaTime);//Moves thourgh speed going though the missile targets.
        if (Vector2.Distance(transform.position, MissileTargets[RandomMissleAttack].position) < 0.2f){
            if (MissileStallTime <= 0)
            {
                RandomMissleAttack = Random.Range(0, MissileTargets.Length);
                MissileStallTime = IgniteMissleTime;

            }else {

                MissileStallTime -= Time.deltaTime;//Allows the missile stall to be able to have real world time.

            }
        }
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = DeathRespwan.transform.position;
        death.Play();
    }

}