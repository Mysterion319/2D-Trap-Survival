using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Allows you to be able to load scenes.
/**
* Looking at this script it allows me to be able to set who is going to be 
* hit which in this script is blub then I can add a trigger for the flag 
* which allows me to have the letter come up once the player hits the flag
* as it loads the graveyard allowing the player to be able to move onto the 
* next level.
*/
public class LetterLoader : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform Letter1;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("GraveYardLetter");//Loads the graveyard letter scene.

    }

}
