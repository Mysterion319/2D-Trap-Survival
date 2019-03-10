using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform RespawnPoint;


    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = RespawnPoint.transform.position;
    }

}