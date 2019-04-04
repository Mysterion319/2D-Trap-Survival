using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is blub then I can add a trigger for the tombstone 
* which allows me to have a respawn when the player dies past the checkpoint.
*/
public class TombStoneCheckPoint : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform tombStoneCheckPoint;//Sets the object for the checkpoint.


    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = tombStoneCheckPoint.transform.position;
    }

}

