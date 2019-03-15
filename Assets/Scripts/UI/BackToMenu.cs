using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToMenu : MonoBehaviour
{
    public Button BackToMenuButton;




    // Use this for initialization
    void Start()
    {
        BackToMenuButton = BackToMenuButton.GetComponent<Button>();
        

    }



    public void ReadTheLetter()
    {
        SceneManager.LoadScene("StartMenu");
    }
 
}