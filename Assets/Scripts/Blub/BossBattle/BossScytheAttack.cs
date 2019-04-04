using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this scythe death script this script allows me to be able to,
* set the speed of the scythe. Then i can also set the different spots that 
* the saw can go to thus with the spin time i can set how long the weapon
* waits this allows the player to have time to avoid the scythe.
*/

public class BossScytheAttack: MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform LevelRespawn;
    public float ScytheSpeed; //Set scythe speed.
    private float ScytheWaitTime;
    public float CountDownToScythe;
    public Transform[] ScytheSlices; //Arrey created to add in the spots for patrol. 
    private int ScytheAttack;
    public AudioSource death;


    void Start()
    {
        ScytheWaitTime = CountDownToScythe;
        ScytheAttack = Random.Range(0, ScytheSlices.Length);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, ScytheSlices[ScytheAttack].position, ScytheSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, ScytheSlices[ScytheAttack].position) < 0.2f)
        {
            if (ScytheWaitTime <= 0)
            {
                ScytheAttack = Random.Range(0, ScytheSlices.Length);
                ScytheWaitTime = CountDownToScythe;

            }
            else
            {

                ScytheWaitTime -= Time.deltaTime;

            }
        }
    }





    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = LevelRespawn.transform.position;
        death.Play();
    }

}
