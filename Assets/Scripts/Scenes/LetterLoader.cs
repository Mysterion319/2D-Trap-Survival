using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LetterLoader : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform EndFlag;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("LoadGraveyardLetter");
       
    }

}