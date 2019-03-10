using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string Level2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blub")
        {
            SceneManager.LoadScene("Level2");
        }
    }

}
