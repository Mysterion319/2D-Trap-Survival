using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScene : MonoBehaviour
{
    public string Level2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blub")
        {
            SceneManager.LoadScene("BossBattle");
        }
    }

}
