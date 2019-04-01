using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
/**
* Then pressing the load graveyard button script will will load allowing
* me to be able to load the second level.
*/
public class LoadGraveyard : MonoBehaviour
{
    [SerializeField] private Transform Blub;
    [SerializeField] private Transform Flag;
    public AudioSource death;

    void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("Level2");//Loads the graveyard letter scene.

    }
}