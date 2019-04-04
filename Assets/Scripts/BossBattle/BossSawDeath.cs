using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this saw death script this script allows me to be able to,
* set the speed of the saw. Then I can also set the different spots that 
* the saw can go to thus with the spin time I can set how long the weapon
* waits this allows the player to have time to avoid the saw.
*/
public class BossSawDeath : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform DeathRespawn;
    public float speed; //Enemy set speed.
    private float SawSpinTime;
    public float StartSawRotateing;
    public Transform[] SawAttacks; //Array created to add in the spots for patrol. 
    private int RandomSawStrikes; // The int needed to have the patrol random.

    public AudioSource death;
    void Start()
    {
        SawSpinTime = StartSawRotateing;
        RandomSawStrikes = Random.Range(0, SawAttacks.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, SawAttacks[RandomSawStrikes].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, SawAttacks[RandomSawStrikes].position) < 0.2f)
        {
            if (SawSpinTime <= 0)
            {
                RandomSawStrikes = Random.Range(0, SawAttacks.Length);
                SawSpinTime = StartSawRotateing;

            }
            else
            {

                SawSpinTime -= Time.deltaTime;

            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = DeathRespawn.transform.position;
        death.Play();
    }

}
