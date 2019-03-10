using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storelastscene : MonoBehaviour {

    private static Storelastscene instance;
    public Vector2 BlubsLastCheckPointPostion;

    void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(instance);
        } else {
            Destroy(gameObject);
        }

    }
}  

