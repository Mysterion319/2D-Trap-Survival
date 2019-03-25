using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public Transform Blub;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 displacement = Blub.position - transform.position;
        displacement = displacement.normalized;
        if (Vector2.Distance(Blub.position, transform.position) > 1.0f)
        {
            transform.position += (displacement * speed * Time.deltaTime);

        }
        else
        {
            
        }

    }
}