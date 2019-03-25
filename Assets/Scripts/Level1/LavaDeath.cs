using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaDeath : MonoBehaviour
{
    [SerializeField] private Transform Blub;//This is for the player that is going to be in contact with the collider.
    [SerializeField] private Transform RespawnPoint;//This where the player will respawn.
    public AudioSource death;//Sound that is played when player dies.

    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;//Has the players transform postion finds the respawn postion.
        death.Play();//Allows the sound to play.
    }

}