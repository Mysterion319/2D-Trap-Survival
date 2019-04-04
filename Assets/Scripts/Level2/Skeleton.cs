using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* Then looking at the skeleton warrior script I can add the weapon to the 
* character that is going to use it. Then fire rate is how fast the weapon is going 
* to go I’ve set the weapon to move at one frame per second. Then the next fire is the
* rate of fire how long it will take for the weapon to fire. Then last the weapon checks 
* when it is time to fire.
*/
public class Skeleton : MonoBehaviour
{

    [SerializeField]
    GameObject BoneWeapon;//name of the weapon to link the prefab to the skeleton.

    float firerate;//Fire rate of the weapon.
    float nextfire;//Sets how the shot will fire next.


    void Start()
    {
        firerate = 1f;//How many seconds the fire rate is.
        nextfire = Time.time;//have the next fire follow time per frame.
    }
    void CheckIfTimeToFire()
    {
        if (Time.time > nextfire)//Has time connected to next fire.
        {
            Instantiate(BoneWeapon, transform.position, Quaternion.identity);//The weapon getting the position and the quaternion.
            nextfire = Time.time + firerate;//Has next fire get the time per frame and get the fire rate.
        }

    }
    void Update()
    {
        CheckIfTimeToFire();//Checks the check fire time.
    }



}

