using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Allows you to be able to load scenes.
public class LetterLoader : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform EndFlag;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("LoadGraveyardLetter");//Loads the graveyard letter scene.
       
    }

}