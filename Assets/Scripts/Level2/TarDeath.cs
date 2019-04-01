using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is blub then i can add a respawn point as this is 
* a trigger this is also where the player will respawn i used this to respwan the player at the start
* of the level.
*/
public class TarDeath : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform RespawnPoint;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;
        death.Play();
    }

}