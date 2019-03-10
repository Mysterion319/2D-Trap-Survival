using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {
    private Storelastscene sls;
	// Use this for initialization
	void Start () {
        sls = GameObject.FindGameObjectWithTag("SLS").GetComponent<Storelastscene>();
	}
	
	void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("blub")){
            sls.BlubsLastCheckPointPostion = transform.position;
        }
    }
}
