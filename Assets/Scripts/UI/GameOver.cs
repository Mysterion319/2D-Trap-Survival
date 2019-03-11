using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public Button SaveHerYes;
    public Button SaveHerNo;
    public Button GiveUpOnHerYes;
    public Button GiveUpOnHerNo;


    // Use this for initialization
    void Start()
    {
        SaveHerYes = SaveHerYes.GetComponent<Button>();
        SaveHerNo = SaveHerNo.GetComponent<Button>();
        GiveUpOnHerYes = GiveUpOnHerYes.GetComponent<Button>();
        GiveUpOnHerNo = GiveUpOnHerNo.GetComponent<Button>();
    }



    public void TryQuestAgain()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void leaveQuest()
    {
        Application.Quit();
    }

}