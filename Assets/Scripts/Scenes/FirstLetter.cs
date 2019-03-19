using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLetter : MonoBehaviour
{
    
    public string GraveyardLetter;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Love_Letter")
        {
            
            SceneManager.LoadScene("GraveyardLetter");
        }
    }

}
