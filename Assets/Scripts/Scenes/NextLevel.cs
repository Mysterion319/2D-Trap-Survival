using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public AudioSource CreepyGraveyard;
   
    public string Level2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blub")
        {
            CreepyGraveyard.Play();
            SceneManager.LoadScene("Level2");
        }
    }

}
