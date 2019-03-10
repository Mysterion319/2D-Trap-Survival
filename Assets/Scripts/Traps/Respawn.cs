using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform saw;
    [SerializeField] private Transform RespawnPoint;


    void OnTriggerEnter2D(Collider2D col)
    {
        saw.transform.position = RespawnPoint.transform.position;
    }

}