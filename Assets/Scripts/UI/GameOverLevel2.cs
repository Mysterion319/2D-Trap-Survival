﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverLevel2 : MonoBehaviour
{
    public Button SaveHerYesButton;
    public Button SaveHerNoButton;
    public Button GiveUpOnHerYesButton;
    public Button GiveUpOnHerNoButton;


    // Use this for initialization
    void Start()
    {
        SaveHerYesButton = SaveHerYesButton.GetComponent<Button>();
        SaveHerNoButton = SaveHerNoButton.GetComponent<Button>();
        GiveUpOnHerYesButton = GiveUpOnHerYesButton.GetComponent<Button>();
        GiveUpOnHerNoButton = GiveUpOnHerNoButton.GetComponent<Button>();
    }



    public void TryQuestAgain()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LeaveQuest()
    {
        Application.Quit();
    }

}