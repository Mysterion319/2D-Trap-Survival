using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelentonWarrior : MonoBehaviour
{

    [SerializeField]
    GameObject BoneWeapon;

    float firerate;
    float nextfire;

    // Use this for initialization
    void Start()
    {
        firerate = 1f;
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToFire();
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextfire)
        {
            Instantiate(BoneWeapon, transform.position, Quaternion.identity);
            nextfire = Time.time + firerate;
        }

    }

}
