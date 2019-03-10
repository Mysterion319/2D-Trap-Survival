using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlubsCheckPoint : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform CheckPoint;


    void OnTriggerEnter2D(Collider2D col)
    {
        Blub.transform.position = CheckPoint.transform.position;
    }

}