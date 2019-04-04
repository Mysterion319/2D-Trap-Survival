using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
* This allows me to be able to trigger the boss battle.
*/
public class LoadCastle : MonoBehaviour
{
    [SerializeField] private Transform Blub;//Allows blub to collide with the door.
    [SerializeField] private Transform Door;//Adds collider to the door.


    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("BossBattle");//Load the final letter.

    }

}
