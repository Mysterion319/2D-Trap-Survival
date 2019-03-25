using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlubsPos : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q)){//Allows the player to be able to jump.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//Loads the Scene.

        }
	}
}
