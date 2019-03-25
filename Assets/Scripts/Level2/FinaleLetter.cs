using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinaleLetter : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform Door;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("CastleLetter");

    }

}