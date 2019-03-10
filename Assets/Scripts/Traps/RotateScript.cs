using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
    public float speed = 5.0f;
    //Update is called every frame
    void Update()
    {
        
        transform.Rotate(new Vector3(0, 0, 45) * speed * Time.deltaTime);
       
    }
}

