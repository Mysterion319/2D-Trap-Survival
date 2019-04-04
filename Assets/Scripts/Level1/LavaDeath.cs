using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is blub then I can add a respawn point as this is 
* a trigger this is also where the player will respawn, I used this to respawn the player at the start
* of the level.
*/
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
