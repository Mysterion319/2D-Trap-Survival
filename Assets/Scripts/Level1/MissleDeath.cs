using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this missile death script this script allows me to be able to,
* set the speed of the missile. Then i can also set the different spots that 
* the missile can go to thus with the spin time i can set how long the weapon
* waits this allows the player to have time to avoid the missile.
* Then i can also set the target which is blub, then set the death respwan 
* to the start of the level.
*/
public class MissleDeath : MonoBehaviour
{
    public float speed; //Enemy set speed.
    private float MissileStallTime;
    public float IgniteMissileTime;//Set the wait time for the missle.
    public Transform[] MissileTargets; //Arrey created to add in the spots for patrol. 
    private int RandomMissleAttack; // So the missle can attack randomly.
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform DeathRespwan;
    public AudioSource death;






    void Start()
    {
        MissileStallTime = IgniteMissileTime;//Says the the missile stall time will equal the ignite missle time.
        RandomMissleAttack = Random.Range(0, MissileTargets.Length);//This is the random missile attack randomly picking one of the missle targets.
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MissileTargets[RandomMissleAttack].position, speed * Time.deltaTime);//Moves thourgh speed going though the missile targets.
        if (Vector2.Distance(transform.position, MissileTargets[RandomMissleAttack].position) < 0.2f){
            if (MissileStallTime <= 0)
            {
                RandomMissleAttack = Random.Range(0, MissileTargets.Length);
                MissileStallTime = IgniteMissileTime;

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