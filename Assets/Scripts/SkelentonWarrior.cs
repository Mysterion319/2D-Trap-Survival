using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkelentonWarrior : MonoBehaviour
{

    [SerializeField]
    GameObject BoneWeapon;

    float firerate;
    float nextBone;
    // Use this for initialization
    void Start()
    {
        float firerate = 1f;
        float nextBone = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckTimeForBone();

    }
    void CheckTimeForBone()
    {
        if (Time.time > nextBone)
        {
            Instantiate(BoneWeapon, transform.position, Quaternion.identity);

        }
    }
}
