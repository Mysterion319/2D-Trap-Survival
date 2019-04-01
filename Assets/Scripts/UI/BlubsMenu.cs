using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class BlubsMenu : MonoBehaviour
{
    public Button PlayButton;//Needed for the Play Button to work.
    public Button ControlButton;//Needed for the control Button to work.
    public Button ObjectiveButton;//Needed for the objective Button to work.
    public Button QuitMenuButton;//Needed for the quit menu Button to work.




    // Use this for initialization
    void Start()
    {
        PlayButton = PlayButton.GetComponent<Button>();//Allows the trigger to work for the play button.
        ControlButton = ControlButton.GetComponent<Button>();//Allows the trigger to work for the control button.
        ObjectiveButton = ObjectiveButton.GetComponent<Button>();//Allows the trigger to work for the objective button.
        QuitMenuButton = QuitMenuButton.GetComponent<Button>();//Allows the trigger to work for the quit button.


    }

       public void StartQuest()//The void needed to start the quest for the play button.
    {
        SceneManager.LoadScene("Level1");//The void needed to start the quest for the play button.
    }
    public void LoadQuestControls()
    {
        SceneManager.LoadScene("Controls");//The void needed to load the quest controls for the control button.
    }
    public void LoadQuestGuide()
    {
        SceneManager.LoadScene("Objective");//The void needed to load the quest guide for the objective button.
    }
        public void ExitGame()//The void needed to exit the quest for the quit button.
    {
        Application.Quit();//Closes the game.
    }
}

