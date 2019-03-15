using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondLetter : MonoBehaviour
{
    public string CastleLetter;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Love_Letter")
        {
            SceneManager.LoadScene("CastleLetter");
        }
    }

}
