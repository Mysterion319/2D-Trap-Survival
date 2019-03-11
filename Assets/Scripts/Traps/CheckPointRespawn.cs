using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointRespawn : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform BlubsCheckPointRespawn;


    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = BlubsCheckPointRespawn.transform.position;
    }

}