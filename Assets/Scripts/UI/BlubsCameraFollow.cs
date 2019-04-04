using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* I use this script as it will allow me to be able to follow the player
* i set the target as blub so the camera can player variable.
*/
public class BlubsCameraFollow : MonoBehaviour
{
    public GameObject blub;//Stores the player variable.


    private Vector3 offset;//A variable to store the distance between blub and the camera.



    void Start()
    {

        offset = transform.position - blub.transform.position; //gets the distance of blubs postion and the cameras postion.
    }


    void LateUpdate()
    {

        transform.position = blub.transform.position + offset; //Makes sure the cameras postion matches blubs postion.
    }

}
