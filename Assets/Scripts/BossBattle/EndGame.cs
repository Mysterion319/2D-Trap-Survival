using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
* Then pressing into the princess allows the win level to show the player
* the win screen which allows the player to know that they have won the game.
*/
public class EndGame : MonoBehaviour
{
    [SerializeField] private Transform Blub;//Allows blub to collide with the door.
    [SerializeField] private Transform Princess;//Adds collider to the door.


    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("Win");//Load the final letter.

    }

}
