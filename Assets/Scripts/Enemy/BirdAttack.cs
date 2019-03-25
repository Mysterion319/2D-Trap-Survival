using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAttack : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform RespawnPoint;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;
        death.Play();
    }

}