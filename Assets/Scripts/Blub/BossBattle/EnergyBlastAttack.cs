﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Then looking at the energy blast class this class allows me to be able,
* to set how many energy blasts are being shot and the speed the weapon is moving.
* Then lastly this class allows me to be able to set who is being hit by the weapon.
*/

public class EnergyBlastAttack : MonoBehaviour
{
    float BossSpeed = 7f;//Set speed of skelenton.

    Rigidbody2D rb;

    Blub target;//Targets the character blub.

    Vector2 moveDirection;
    [SerializeField] private Transform Blub;//This is for the player that is going to be in contact with the collider.
    [SerializeField] private Transform CheckPoint;//This where the player will respawn.
   



    [SerializeField] private Transform Skelenton1;//This is for the player that is going to be in contact with the collider.
    [SerializeField] private Transform Death;//This where the player will respawn.

    [SerializeField] private Transform Skelenton2;//This is for the player that is going to be in contact with the collider.
    [SerializeField] private Transform Death2;//This where the player will respawn.

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Blub>();//Finds the object tag which is blub.
        moveDirection = (target.transform.position - transform.position).normalized * BossSpeed;//Moves the weapon the speed of the skelenton.
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);//Moves the weapon in the x and y direction.
        Destroy(gameObject, 10f);//Destroys the game object.






    }

    // Update is called once per frame
    void OnTriggerEnter2d(Collider2D col)
    {
        if (col.gameObject.name.Equals("Blub"))
        {
            Debug.Log("Hit");//Adds a log to let me know it hit.
            Destroy(gameObject);//destroys the weapon.
        }
        Blub.transform.position = CheckPoint.transform.position;
        Skelenton1.transform.position = Death.transform.position;
        Skelenton2.transform.position = Death2.transform.position;

    }
}



