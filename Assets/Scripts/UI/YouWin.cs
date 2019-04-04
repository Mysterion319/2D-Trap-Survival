using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class YouWin : MonoBehaviour
{
    public Button QuitButton;//Needed for the Play Button to work.
  



    // Use this for initialization
    void Start()
    {
        QuitButton = QuitButton.GetComponent<Button>();//Allows the trigger to work for the play button.
       

    }

    public void ExitGame()//The void needed to exit the quest for the quit button.
    {
        Application.Quit();//Closes the game.
    }
}

