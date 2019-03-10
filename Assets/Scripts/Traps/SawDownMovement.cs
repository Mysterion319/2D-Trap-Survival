using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawDownMovement : MonoBehaviour
{
    public static int movespeed = 1;
    public Vector3 userDirection = Vector3.down;
    [SerializeField] Transform respawnPoint;    // Update is called once per frame
    void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }

}
