using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreBlubsLastPos : MonoBehaviour
{

    private static StoreBlubsLastPos instance;
    public Vector2 BlubsLastCheckPointPostion;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}

