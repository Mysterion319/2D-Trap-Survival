using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is blub then i can add a trigger for the door 
* which allows me to have the letter come up once the player hits the door
* as it loads the castle allowing the player to be able to move onto the 
* next level.
*/
public class FinaleLetter : MonoBehaviour
{
    [SerializeField] private Transform Blub;//Allows blub to colide with the door.
    [SerializeField] private Transform SecondLetter;//Adds collider to the door.
 

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("CastleLetter");//Load the final letter.

    }

}