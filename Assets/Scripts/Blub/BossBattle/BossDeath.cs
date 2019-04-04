using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is the boss this allows me to add a way for the 
* boss to be beaten and end the level.
*/
public class BossDeath : MonoBehaviour
{
    [SerializeField] private Transform Boss;
    [SerializeField] private Transform DeathPoint;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        Boss.transform.position = DeathPoint.transform.position;
        death.Play();
    }

}