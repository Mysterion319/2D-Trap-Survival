using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour {
    public static int movespeed = -1;
    public Vector3 userDirection = Vector3.left;
   
    void Update ()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }
    
}
