using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class HowToPlay : MonoBehaviour
{
    public Button GiveUpButton;
    public Button ReadyUpButton;



    // Use this for initialization
    void Start()
    {
        GiveUpButton = GiveUpButton.GetComponent<Button>();
        ReadyUpButton = ReadyUpButton.GetComponent<Button>();
      
    }



    public void GiveUpTheQuest()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void TryTheQuestAgain()
    {
        Application.Quit();
    }

}