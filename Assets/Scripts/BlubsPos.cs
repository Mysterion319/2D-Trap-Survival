using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlubsPos : MonoBehaviour {
    private Storelastscene sls;

	// Use this for initialization
	void Start () {
        sls = GameObject.FindGameObjectWithTag("SLS").GetComponent<Storelastscene>();
        transform.position = sls.BlubsLastCheckPointPostion;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
	}
}
